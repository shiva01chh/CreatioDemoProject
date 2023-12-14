namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PassportConstantsSchema

	/// <exclude/>
	public class PassportConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PassportConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PassportConstantsSchema(PassportConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c1419524-889b-4d29-8d12-e03bf9d0efa5");
			Name = "PassportConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,147,219,138,219,48,16,64,159,19,200,63,136,205,75,251,160,141,172,155,37,122,1,203,151,210,151,18,200,254,128,98,203,91,131,45,27,203,110,49,101,255,189,114,182,45,73,119,33,221,38,173,192,98,60,12,98,142,206,104,116,149,189,7,187,201,13,166,121,179,90,174,150,86,55,198,117,58,55,224,206,244,189,118,109,57,220,198,173,45,171,251,177,215,67,213,218,213,242,219,106,185,232,198,125,93,229,192,13,62,151,131,188,214,206,129,173,223,186,182,31,124,185,207,219,193,249,186,185,118,177,217,108,192,91,55,54,141,238,167,247,63,19,235,245,122,254,14,11,172,143,254,142,178,143,33,128,199,133,143,241,237,175,115,55,199,7,159,182,213,27,93,180,182,158,192,135,177,42,192,110,236,186,122,218,234,169,49,118,72,76,173,167,172,111,155,76,231,3,120,7,172,249,122,168,122,117,147,166,81,18,17,36,33,142,211,16,210,128,196,80,40,206,97,42,5,197,20,71,52,193,248,230,245,225,174,174,65,246,15,209,182,181,182,39,104,60,139,153,64,76,66,25,211,8,82,42,2,40,194,144,65,165,162,36,163,17,141,18,22,156,69,123,161,177,75,105,118,190,194,100,149,173,220,103,83,156,138,146,169,34,216,235,81,65,154,64,170,168,130,34,73,164,87,230,65,36,67,33,75,200,245,104,174,11,244,169,29,158,101,82,2,121,152,4,65,66,50,1,41,243,96,81,154,10,136,83,204,9,10,21,162,140,255,217,240,157,119,115,41,200,221,212,153,31,225,9,67,34,184,200,168,242,111,71,82,238,189,168,0,74,191,67,158,41,73,34,230,31,84,74,95,226,101,253,100,168,254,162,243,143,246,75,91,229,230,200,193,232,98,109,115,83,255,102,128,148,123,73,176,209,176,36,124,15,3,26,32,136,185,12,32,66,1,99,5,162,4,35,118,89,247,151,76,210,115,24,91,221,15,149,174,103,47,213,41,11,34,161,164,251,146,65,134,13,135,69,25,120,19,97,176,159,89,10,142,140,36,34,63,63,77,255,195,196,147,206,185,20,5,145,101,113,182,243,197,195,106,249,48,3,204,235,59,16,119,103,97,205,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c1419524-889b-4d29-8d12-e03bf9d0efa5"));
		}

		#endregion

	}

	#endregion

}

