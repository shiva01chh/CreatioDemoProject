namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UtmFormSubmitFieldMapperSchema

	/// <exclude/>
	public class UtmFormSubmitFieldMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UtmFormSubmitFieldMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UtmFormSubmitFieldMapperSchema(UtmFormSubmitFieldMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6f3e820e-e5f7-490a-95fd-22e45f639cf5");
			Name = "UtmFormSubmitFieldMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,193,110,218,64,16,61,19,41,255,48,114,46,32,33,115,15,224,67,105,136,144,72,133,32,168,135,170,135,197,30,195,170,222,93,119,119,76,133,162,254,123,199,94,108,76,3,164,245,197,242,236,155,121,111,222,140,87,11,133,46,23,49,194,43,90,43,156,73,41,156,24,157,202,109,97,5,73,163,239,239,222,238,239,58,133,147,122,11,171,131,35,84,195,191,190,25,159,101,24,151,96,23,62,163,70,43,227,119,152,185,212,63,79,193,54,151,197,112,42,98,50,86,162,99,4,99,30,44,110,185,24,76,50,225,220,35,172,73,77,141,85,171,98,163,36,77,37,102,201,139,200,115,180,21,118,48,24,192,72,234,29,147,82,98,98,136,45,166,227,96,214,130,5,131,136,113,223,62,99,42,138,140,62,73,157,176,130,46,29,114,52,105,119,54,41,28,25,213,130,247,250,240,133,61,129,49,4,215,136,131,222,119,174,152,23,155,76,50,97,41,242,170,70,120,132,247,20,156,252,86,137,63,117,202,214,145,208,196,221,46,172,220,11,66,127,94,117,231,10,165,132,61,68,117,224,117,135,144,137,170,13,200,197,22,97,189,156,67,90,150,15,155,156,65,59,41,247,37,33,46,89,192,145,45,51,231,190,194,130,11,172,109,86,169,43,123,110,135,151,243,96,248,129,14,118,155,71,201,125,254,55,255,242,152,217,48,215,129,154,243,1,117,226,237,57,247,106,97,13,123,72,188,45,108,86,53,131,27,26,159,145,28,16,11,253,133,155,157,49,63,192,153,194,198,120,77,168,31,233,81,225,87,159,178,170,50,96,28,157,7,154,145,133,71,203,228,45,175,26,29,168,73,210,1,52,175,216,63,137,120,170,240,126,35,35,8,78,75,246,145,77,47,72,59,147,92,242,232,230,223,18,242,171,250,116,254,191,169,229,236,141,76,160,57,235,206,158,116,161,208,138,77,134,35,175,52,170,45,246,136,62,204,165,163,209,209,50,190,33,10,165,57,61,2,85,210,36,30,212,131,242,110,233,116,218,177,112,137,121,198,247,81,247,194,130,246,155,17,160,221,203,246,12,218,168,222,240,122,209,179,173,187,94,174,134,157,151,252,125,209,113,31,61,15,86,177,214,243,7,198,244,28,181,102,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f3e820e-e5f7-490a-95fd-22e45f639cf5"));
		}

		#endregion

	}

	#endregion

}

