namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITemplateLoaderSchema

	/// <exclude/>
	public class ITemplateLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITemplateLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITemplateLoaderSchema(ITemplateLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0678da09-bb18-43d7-b171-709841aeb44c");
			Name = "ITemplateLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9fb8de7b-ba51-4bde-a802-902958879110");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,83,65,106,195,64,12,60,59,144,63,136,156,82,40,246,3,146,250,18,66,8,228,214,244,1,138,45,155,5,175,108,118,181,7,83,250,247,238,110,187,137,147,54,61,166,198,23,201,51,163,209,8,51,106,178,3,86,4,71,50,6,109,223,72,190,233,185,81,173,51,40,170,231,249,236,125,62,203,156,85,220,194,235,104,133,244,234,92,111,122,67,215,85,190,101,81,162,200,250,182,255,48,184,83,167,42,80,44,100,154,48,100,127,36,61,116,40,116,232,177,38,227,33,65,61,43,138,2,214,214,105,141,102,44,83,227,205,146,129,170,103,166,42,24,201,207,192,98,138,12,168,205,25,4,55,101,84,207,90,146,96,51,251,136,166,126,159,182,35,177,128,12,164,81,117,32,223,54,65,12,178,237,98,18,112,26,65,121,144,170,201,47,217,40,239,110,185,30,208,160,54,212,0,251,32,95,22,145,157,118,220,215,139,162,124,74,3,144,107,168,169,65,215,9,116,200,173,195,150,238,236,20,59,81,249,142,108,185,189,118,121,177,148,175,139,72,188,232,24,18,103,216,222,82,166,139,5,178,140,158,154,176,129,28,47,57,134,92,210,224,229,206,169,26,110,188,60,173,254,59,212,20,230,159,26,9,244,69,127,68,238,83,157,201,244,242,240,211,238,195,143,246,12,177,123,177,21,174,24,126,15,255,78,159,79,36,219,145,201,30,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0678da09-bb18-43d7-b171-709841aeb44c"));
		}

		#endregion

	}

	#endregion

}

