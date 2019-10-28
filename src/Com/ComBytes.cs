using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diadoc.Api.Com
{
	[ComVisible(true)]
	[Guid("AC96A3DD-E099-44CC-ABD5-11C303307159")]
	public interface IComBytes
	{
		byte[] Bytes { get; set; }

		void ReadFromFile(string path);
		void SaveToFile(string path);

		void ReadFromStream([In, MarshalAs(UnmanagedType.AsAny)] object stream);
	}

	[ComVisible(true)]
	[Guid("97D998E3-E603-4450-A027-EA774091BE72")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IComBytes))]
	public class ComBytes : SafeComObject, IComBytes
	{
		public byte[] Bytes { get; set; }

		public void ReadFromFile(string path)
		{
			Bytes = File.ReadAllBytes(path);
		}

		public void SaveToFile(string path)
		{
			if (Bytes != null)
			{
				File.WriteAllBytes(path, Bytes);
			}
		}

		public void ReadFromStream([In, MarshalAs(UnmanagedType.AsAny)] object stream)
		{
			Bytes = ReadStream(stream);
		}

		private byte[] ReadStream([In, MarshalAs(UnmanagedType.AsAny)] object stream)
		{
			var comStream = stream as IStream;
			if (comStream == null)
			{
				throw new ArgumentException("Invalid stream");
			}

			const int bufferSize = 45000;
			var buffer = new byte[bufferSize];
			var bytesReadPtr = Marshal.AllocHGlobal(4);

			var result = new MemoryStream();
			try
			{
				int bytesRead;
				do
				{
					comStream.Read(buffer, bufferSize, bytesReadPtr);
					bytesRead = Marshal.ReadInt32(bytesReadPtr);
					result.Write(buffer, 0, bytesRead);
				} while (bytesRead > 0);

				return result.ToArray();
			}
			finally
			{
				if (result != null)
				{
					((IDisposable) result).Dispose();
				}

				Marshal.FreeHGlobal(bytesReadPtr);
			}
		}
	}
}