//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Invoicing/AcceptanceCertificate552Info.proto
// Note: requires additional types generated from: Invoicing/InvoiceInfo.proto
// Note: requires additional types generated from: Invoicing/ExtendedSigner.proto
// Note: requires additional types generated from: Invoicing/ExtendedOrganizationInfo.proto
// Note: requires additional types generated from: Invoicing/UniversalTransferDocumentInfo.proto
// Note: requires additional types generated from: Invoicing/TovTorgInfo.proto
namespace Diadoc.Api.Proto.Invoicing
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AcceptanceCertificate552SellerTitleInfo")]
  public partial class AcceptanceCertificate552SellerTitleInfo : global::ProtoBuf.IExtensible
  {
    public AcceptanceCertificate552SellerTitleInfo() {}
    
    private Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo _Seller;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Seller", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo Seller
    {
      get { return _Seller; }
      set { _Seller = value; }
    }
    private Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo _Buyer;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Buyer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo Buyer
    {
      get { return _Buyer; }
      set { _Buyer = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner> _Signers = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner>();
    [global::ProtoBuf.ProtoMember(3, Name=@"Signers", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner> Signers
    {
      get { return _Signers; }
    }
  
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.GroundInfo> _Grounds = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.GroundInfo>();
    [global::ProtoBuf.ProtoMember(4, Name=@"Grounds", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.GroundInfo> Grounds
    {
      get { return _Grounds; }
    }
  
    private string _Currency;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Currency", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Currency
    {
      get { return _Currency; }
      set { _Currency = value; }
    }

    private string _CurrencyRate = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"CurrencyRate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string CurrencyRate
    {
      get { return _CurrencyRate; }
      set { _CurrencyRate = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AcceptanceCertificate552WorkDescription> _Works = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AcceptanceCertificate552WorkDescription>();
    [global::ProtoBuf.ProtoMember(7, Name=@"Works", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AcceptanceCertificate552WorkDescription> Works
    {
      get { return _Works; }
    }
  
    private string _DocumentDate;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"DocumentDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DocumentDate
    {
      get { return _DocumentDate; }
      set { _DocumentDate = value; }
    }

    private string _DocumentNumber = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DocumentNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string DocumentNumber
    {
      get { return _DocumentNumber; }
      set { _DocumentNumber = value; }
    }

    private string _RevisionDate = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"RevisionDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string RevisionDate
    {
      get { return _RevisionDate; }
      set { _RevisionDate = value; }
    }

    private string _RevisionNumber = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"RevisionNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string RevisionNumber
    {
      get { return _RevisionNumber; }
      set { _RevisionNumber = value; }
    }
    private string _DocumentCreator;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"DocumentCreator", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DocumentCreator
    {
      get { return _DocumentCreator; }
      set { _DocumentCreator = value; }
    }

    private string _DocumentCreatorBase = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DocumentCreatorBase", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string DocumentCreatorBase
    {
      get { return _DocumentCreatorBase; }
      set { _DocumentCreatorBase = value; }
    }

    private string _OperationType = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"OperationType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string OperationType
    {
      get { return _OperationType; }
      set { _OperationType = value; }
    }

    private string _OperationTitle = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"OperationTitle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string OperationTitle
    {
      get { return _OperationTitle; }
      set { _OperationTitle = value; }
    }

    private string _GovernmentContractInfo = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"GovernmentContractInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string GovernmentContractInfo
    {
      get { return _GovernmentContractInfo; }
      set { _GovernmentContractInfo = value; }
    }

    private Diadoc.Api.Proto.Invoicing.AdditionalInfoId _AdditionalInfoId = null;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"AdditionalInfoId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.AdditionalInfoId AdditionalInfoId
    {
      get { return _AdditionalInfoId; }
      set { _AdditionalInfoId = value; }
    }
    private string _DocumentName;
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"DocumentName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DocumentName
    {
      get { return _DocumentName; }
      set { _DocumentName = value; }
    }
    private Diadoc.Api.Proto.Invoicing.AcceptanceCertificate552TransferInfo _TransferInfo;
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"TransferInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Invoicing.AcceptanceCertificate552TransferInfo TransferInfo
    {
      get { return _TransferInfo; }
      set { _TransferInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AcceptanceCertificate552TransferInfo")]
  public partial class AcceptanceCertificate552TransferInfo : global::ProtoBuf.IExtensible
  {
    public AcceptanceCertificate552TransferInfo() {}
    
    private string _OperationInfo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"OperationInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OperationInfo
    {
      get { return _OperationInfo; }
      set { _OperationInfo = value; }
    }

    private string _TransferDate = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"TransferDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TransferDate
    {
      get { return _TransferDate; }
      set { _TransferDate = value; }
    }

    private string _CreatedThingTransferDate = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"CreatedThingTransferDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string CreatedThingTransferDate
    {
      get { return _CreatedThingTransferDate; }
      set { _CreatedThingTransferDate = value; }
    }

    private string _CreatedThingInfo = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"CreatedThingInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string CreatedThingInfo
    {
      get { return _CreatedThingInfo; }
      set { _CreatedThingInfo = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo> _AdditionalInfos = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo>();
    [global::ProtoBuf.ProtoMember(5, Name=@"AdditionalInfos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo> AdditionalInfos
    {
      get { return _AdditionalInfos; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AcceptanceCertificate552WorkDescription")]
  public partial class AcceptanceCertificate552WorkDescription : global::ProtoBuf.IExtensible
  {
    public AcceptanceCertificate552WorkDescription() {}
    

    private string _StartingDate = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"StartingDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string StartingDate
    {
      get { return _StartingDate; }
      set { _StartingDate = value; }
    }

    private string _CompletionDate = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"CompletionDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string CompletionDate
    {
      get { return _CompletionDate; }
      set { _CompletionDate = value; }
    }

    private string _TotalWithVatExcluded = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"TotalWithVatExcluded", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TotalWithVatExcluded
    {
      get { return _TotalWithVatExcluded; }
      set { _TotalWithVatExcluded = value; }
    }

    private string _TotalVat = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"TotalVat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TotalVat
    {
      get { return _TotalVat; }
      set { _TotalVat = value; }
    }
    private string _Total;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Total", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Total
    {
      get { return _Total; }
      set { _Total = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AcceptanceCertificate552WorkItem> _Items = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AcceptanceCertificate552WorkItem>();
    [global::ProtoBuf.ProtoMember(6, Name=@"Items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AcceptanceCertificate552WorkItem> Items
    {
      get { return _Items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AcceptanceCertificate552WorkItem")]
  public partial class AcceptanceCertificate552WorkItem : global::ProtoBuf.IExtensible
  {
    public AcceptanceCertificate552WorkItem() {}
    

    private string _Name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }

    private string _Description = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Description
    {
      get { return _Description; }
      set { _Description = value; }
    }

    private string _UnitCode = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"UnitCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string UnitCode
    {
      get { return _UnitCode; }
      set { _UnitCode = value; }
    }

    private string _UnitName = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"UnitName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string UnitName
    {
      get { return _UnitName; }
      set { _UnitName = value; }
    }

    private string _Price = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Price", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    private string _Quantity = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Quantity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Quantity
    {
      get { return _Quantity; }
      set { _Quantity = value; }
    }

    private string _SubtotalWithVatExcluded = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"SubtotalWithVatExcluded", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string SubtotalWithVatExcluded
    {
      get { return _SubtotalWithVatExcluded; }
      set { _SubtotalWithVatExcluded = value; }
    }

    private string _Vat = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Vat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Vat
    {
      get { return _Vat; }
      set { _Vat = value; }
    }

    private string _Subtotal = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Subtotal", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Subtotal
    {
      get { return _Subtotal; }
      set { _Subtotal = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo> _AdditionalInfos = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo>();
    [global::ProtoBuf.ProtoMember(10, Name=@"AdditionalInfos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo> AdditionalInfos
    {
      get { return _AdditionalInfos; }
    }
  

    private Diadoc.Api.Proto.Invoicing.TaxRate _TaxRate = Diadoc.Api.Proto.Invoicing.TaxRate.Percent_18;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"TaxRate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Invoicing.TaxRate.Percent_18)]
    public Diadoc.Api.Proto.Invoicing.TaxRate TaxRate
    {
      get { return _TaxRate; }
      set { _TaxRate = value; }
    }

    private string _ItemAccountDebit = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"ItemAccountDebit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ItemAccountDebit
    {
      get { return _ItemAccountDebit; }
      set { _ItemAccountDebit = value; }
    }

    private string _ItemAccountCredit = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"ItemAccountCredit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ItemAccountCredit
    {
      get { return _ItemAccountCredit; }
      set { _ItemAccountCredit = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AcceptanceCertificate552BuyerTitleInfo")]
  public partial class AcceptanceCertificate552BuyerTitleInfo : global::ProtoBuf.IExtensible
  {
    public AcceptanceCertificate552BuyerTitleInfo() {}
    
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner> _Signers = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner>();
    [global::ProtoBuf.ProtoMember(1, Name=@"Signers", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner> Signers
    {
      get { return _Signers; }
    }
  
    private string _DocumentCreator;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"DocumentCreator", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DocumentCreator
    {
      get { return _DocumentCreator; }
      set { _DocumentCreator = value; }
    }

    private string _DocumentCreatorBase = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DocumentCreatorBase", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string DocumentCreatorBase
    {
      get { return _DocumentCreatorBase; }
      set { _DocumentCreatorBase = value; }
    }

    private string _OperationType = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"OperationType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string OperationType
    {
      get { return _OperationType; }
      set { _OperationType = value; }
    }
    private string _DocumentName;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"DocumentName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DocumentName
    {
      get { return _DocumentName; }
      set { _DocumentName = value; }
    }
    private string _OperationInfo;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"OperationInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OperationInfo
    {
      get { return _OperationInfo; }
      set { _OperationInfo = value; }
    }

    private string _AcceptDate = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"AcceptDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string AcceptDate
    {
      get { return _AcceptDate; }
      set { _AcceptDate = value; }
    }

    private string _CreatedThingAcceptDate = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"CreatedThingAcceptDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string CreatedThingAcceptDate
    {
      get { return _CreatedThingAcceptDate; }
      set { _CreatedThingAcceptDate = value; }
    }

    private string _CreatedThingInfo = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CreatedThingInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string CreatedThingInfo
    {
      get { return _CreatedThingInfo; }
      set { _CreatedThingInfo = value; }
    }

    private Diadoc.Api.Proto.Invoicing.AdditionalInfoId _AdditionalInfoId = null;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"AdditionalInfoId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.AdditionalInfoId AdditionalInfoId
    {
      get { return _AdditionalInfoId; }
      set { _AdditionalInfoId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}