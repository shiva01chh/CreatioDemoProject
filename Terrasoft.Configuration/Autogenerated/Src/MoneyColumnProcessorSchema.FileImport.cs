namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MoneyColumnProcessorSchema

	/// <exclude/>
	public class MoneyColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MoneyColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MoneyColumnProcessorSchema(MoneyColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1ada78ef-dac1-4b3e-9c3b-95c44f2ee05b");
			Name = "MoneyColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a247561-b87d-48fb-9e13-b6a8baa960d3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,75,235,64,16,199,207,10,126,135,161,94,90,120,36,247,218,22,158,149,62,122,80,4,173,23,241,176,221,76,234,66,178,155,55,179,43,20,241,187,59,217,52,218,196,40,152,75,118,135,255,252,103,230,151,137,85,37,114,165,52,194,61,18,41,118,185,79,150,206,230,102,23,72,121,227,108,178,50,5,174,203,202,145,63,59,125,61,59,61,9,108,236,14,238,246,236,177,188,248,184,31,103,19,126,23,79,86,74,123,71,6,89,20,162,57,39,220,73,13,88,22,138,121,10,215,206,226,126,233,138,80,218,91,114,26,153,29,69,93,154,166,48,51,246,25,201,248,204,105,208,132,249,124,180,42,156,242,61,249,40,93,180,122,14,101,169,104,223,222,255,90,48,150,189,178,50,171,203,193,63,27,6,93,215,5,57,144,64,112,150,205,182,64,200,29,65,213,248,213,19,196,166,64,199,50,240,162,138,128,156,180,37,210,163,26,143,87,152,171,80,248,75,99,51,201,27,251,125,133,46,31,175,123,13,78,254,192,141,48,135,57,88,121,137,96,104,232,201,228,73,28,171,176,45,140,62,52,57,36,131,41,12,49,144,212,215,136,237,147,175,204,230,41,212,236,5,243,109,244,109,20,191,37,251,5,109,12,44,9,149,71,238,2,150,249,69,137,120,240,28,26,64,60,147,15,211,180,239,58,171,20,169,50,114,154,143,2,35,201,24,22,117,189,149,163,197,70,238,242,85,218,64,50,75,163,58,38,31,192,13,85,28,111,58,62,208,181,157,8,209,173,98,28,247,195,245,226,159,188,29,160,162,205,26,174,93,200,82,163,66,242,178,220,211,250,236,37,23,179,159,40,95,74,165,95,64,190,82,94,53,11,216,176,13,214,252,151,179,201,208,122,147,27,164,111,80,86,109,47,224,94,228,111,20,61,252,11,38,139,126,15,181,221,189,184,109,214,25,204,23,221,88,18,1,246,101,23,131,20,26,54,221,160,196,142,159,119,220,134,118,46,107,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1ada78ef-dac1-4b3e-9c3b-95c44f2ee05b"));
		}

		#endregion

	}

	#endregion

}

