﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Diadoc.Api.Com;
using NUnit.Framework;

namespace Diadoc.Api.Tests
{
	[TestFixture]
	public class ComInterfaceAttributes_Test
	{
		[Test]
		public void HasGuids([ValueSource("GetAllComVisibleTypes")] Type type)
		{
			Assert.That(() => new Guid(GetCustomAttribute<GuidAttribute>(type).Value), Throws.Nothing);
		}

		[Test]
		public void InterfaceType([ValueSource("GetComVisibleInterfaceTypes")] Type type)
		{
			var interfaceTypeAttribute = GetCustomAttribute<InterfaceTypeAttribute>(type);
			if (interfaceTypeAttribute != null)
				Assert.That(interfaceTypeAttribute.Value, Is.EqualTo(ComInterfaceType.InterfaceIsDual));
		}

		[Test]
		public void ClassInterface([ValueSource("GetComVisibleClassTypes")] Type type)
		{
			var classInterfaceAttribute = GetCustomAttribute<ClassInterfaceAttribute>(type);
			Assert.IsNotNull(classInterfaceAttribute);
			Assert.That(classInterfaceAttribute.Value, Is.EqualTo(ClassInterfaceType.None));
		}

		[Test]
		public void ComDefaultInterface([ValueSource("GetComVisibleClassTypes")] Type type)
		{
			var comDefaultInterfaceAttribute = GetCustomAttribute<ComDefaultInterfaceAttribute>(type);
			Assert.IsNotNull(comDefaultInterfaceAttribute);

			var defaultInterfaceType = comDefaultInterfaceAttribute.Value;
			Assert.True(IsComVisible(defaultInterfaceType));
			Assert.True(type.GetInterfaces().Contains(defaultInterfaceType));
		}

		[Test]
		public void ComVisibleTypes_HasNoNullableProperties([ValueSource("GetComVisibleInterfaceTypes")] Type type)
		{
			var propertyInfos = type.GetProperties();
			foreach (var info in propertyInfos)
			{
				Assert.That(info.PropertyType.Name.Contains("Nullable"), Is.False,
					"Type: {" + type + "} contains nullable property {" + info.Name + "}");
			}
		}

		[Test]
		public void SafeComObject([ValueSource("GetComVisibleClassTypes")] Type type)
		{
			Assert.True(type.IsSubclassOf(typeof(SafeComObject)));
		}

		[Test]
		public void MarshalAs([ValueSource("GetComVisibleClassTypes")] Type type)
		{
			var excludedTypes = new[] { typeof(string) };

			var comDefaultInterfaceAttribute = GetCustomAttribute<ComDefaultInterfaceAttribute>(type);
			Assert.IsNotNull(comDefaultInterfaceAttribute);
			var comDefaultInterfaceType = comDefaultInterfaceAttribute.Value;

			foreach (var methodInfo in comDefaultInterfaceType.GetMethods().Where(m => !m.IsSpecialName))
			{
				foreach (var parameterInfo in methodInfo.GetParameters()
					.Where(p => p.ParameterType.IsClass && IsComVisible(p.ParameterType) && !excludedTypes.Contains(p.ParameterType)))
				{
					var message = string.Format("{0}.{1}(..., {2} {3}, ...)", type.FullName, methodInfo.Name, parameterInfo.ParameterType.Name, parameterInfo.Name);
					var marshalAsAttribute = (MarshalAsAttribute)Attribute.GetCustomAttribute(parameterInfo, typeof(MarshalAsAttribute));
					Assert.IsNotNull(marshalAsAttribute, message);
					Assert.That(marshalAsAttribute.Value, Is.AnyOf(UnmanagedType.IDispatch, UnmanagedType.AsAny), message);
					Assert.That(parameterInfo.ParameterType, Is.EqualTo(typeof(object)), message);
				}
			}
		}

		private static IEnumerable<Type> GetComVisibleClassTypes()
		{
			return GetAllComVisibleTypes().Where(t => t.IsClass);
		}

		private static IEnumerable<Type> GetComVisibleInterfaceTypes()
		{
			return GetAllComVisibleTypes().Where(t => t.IsInterface);
		}

		private static IEnumerable<Type> GetAllComVisibleTypes()
		{
			return typeof(SafeComObject).Assembly.GetTypes().Where(IsComVisible);
		}

		private static bool IsComVisible(Type type)
		{
			var comVisibleAttribute = GetCustomAttribute<ComVisibleAttribute>(type);
			return comVisibleAttribute != null && comVisibleAttribute.Value;
		}

		private static T GetCustomAttribute<T>(MemberInfo element) where T : Attribute
		{
			return (T)Attribute.GetCustomAttribute(element, typeof(T));
		}
	}
}