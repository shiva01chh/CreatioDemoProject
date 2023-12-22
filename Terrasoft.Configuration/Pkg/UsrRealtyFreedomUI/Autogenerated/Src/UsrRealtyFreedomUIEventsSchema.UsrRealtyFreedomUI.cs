namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyFreedomUIEventsSchema

	/// <exclude/>
	public class UsrRealtyFreedomUIEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyFreedomUIEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyFreedomUIEventsSchema(UsrRealtyFreedomUIEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("36c8dc56-3a99-4395-ae3d-fa30479a9061");
			Name = "UsrRealtyFreedomUIEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,110,219,48,16,188,235,43,22,66,14,18,96,16,201,53,110,3,212,142,83,24,8,210,34,150,115,41,122,160,169,181,194,130,15,129,164,156,186,133,255,189,75,209,110,45,219,69,187,39,105,57,59,59,51,88,48,92,163,111,185,64,168,208,57,238,237,58,176,169,53,107,217,116,142,7,105,77,246,51,3,170,206,75,211,192,98,235,3,234,241,81,231,120,74,107,107,254,246,230,144,205,76,144,65,162,255,15,8,155,109,208,132,61,242,75,223,221,246,173,71,73,2,12,186,98,33,94,81,243,39,82,15,239,33,95,122,247,140,92,133,237,131,67,172,173,94,206,243,242,107,63,220,118,43,37,5,8,197,189,135,132,185,64,7,183,48,225,30,47,188,244,36,41,130,35,58,187,33,221,178,70,216,88,89,195,39,51,55,30,93,32,67,133,93,125,67,17,192,163,169,209,141,32,49,78,112,77,238,122,222,15,174,241,128,229,111,194,63,212,177,86,36,130,29,211,29,120,176,28,15,128,137,23,92,111,136,18,40,82,163,76,248,33,182,70,33,53,87,208,58,41,98,90,105,136,125,196,80,109,91,172,167,86,117,218,188,112,213,225,187,61,244,174,136,137,126,142,248,229,226,62,63,217,45,215,80,36,174,59,184,185,62,84,57,192,12,109,197,66,54,247,83,110,4,42,172,73,68,112,29,142,179,51,148,15,46,158,5,221,164,231,13,86,168,91,197,67,20,109,240,13,30,173,224,74,254,224,43,133,139,30,87,236,173,44,41,46,58,90,67,201,211,197,178,103,244,182,115,130,64,214,17,203,8,206,214,196,186,112,52,233,234,242,17,228,103,171,60,235,19,154,251,202,218,137,108,210,95,94,178,202,238,165,148,255,116,67,46,82,131,61,88,167,121,40,78,92,210,218,27,118,61,185,58,205,59,86,120,117,246,173,15,97,246,93,96,27,109,30,198,79,208,187,108,248,181,203,118,89,246,11,35,19,95,225,231,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bb12fa76-4669-aedb-4405-0045c450c158"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430"),
				CreatedInSchemaUId = new Guid("36c8dc56-3a99-4395-ae3d-fa30479a9061"),
				ModifiedInSchemaUId = new Guid("36c8dc56-3a99-4395-ae3d-fa30479a9061")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36c8dc56-3a99-4395-ae3d-fa30479a9061"));
		}

		#endregion

	}

	#endregion

}

