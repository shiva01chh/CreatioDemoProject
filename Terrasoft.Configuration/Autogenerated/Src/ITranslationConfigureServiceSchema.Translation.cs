namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationConfigureServiceSchema

	/// <exclude/>
	public class ITranslationConfigureServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationConfigureServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationConfigureServiceSchema(ITranslationConfigureServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2811bd82-3edc-4fba-a9ab-749eda63fb70");
			Name = "ITranslationConfigureService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,75,107,131,64,16,62,27,200,127,88,236,37,129,176,222,91,147,67,11,45,41,164,41,49,144,67,200,97,163,163,149,234,174,157,89,3,18,250,223,187,174,143,198,22,210,122,209,253,156,239,177,51,35,69,14,84,136,16,216,22,16,5,169,88,243,7,37,227,52,41,81,232,84,73,190,69,33,41,179,223,227,209,121,60,114,74,74,101,194,130,138,52,228,60,0,60,165,33,172,84,4,217,221,181,159,124,7,71,83,96,74,110,16,18,35,198,150,82,3,198,198,250,150,45,47,76,58,119,104,217,150,227,121,30,243,169,204,115,129,213,162,61,27,147,11,26,11,85,67,99,212,240,120,71,243,46,120,251,86,212,152,104,20,161,158,188,152,251,179,57,115,175,4,112,167,7,195,44,202,99,150,134,44,237,66,255,145,217,57,219,220,191,130,91,224,9,52,117,241,251,244,89,153,75,50,239,86,137,247,108,239,39,221,71,208,37,74,90,248,4,192,66,132,120,62,204,111,165,250,76,209,198,76,88,73,2,215,91,248,94,199,173,197,246,235,2,176,187,128,237,199,193,194,102,84,75,121,82,239,48,89,129,126,83,81,221,160,215,117,176,117,103,108,3,31,37,144,126,84,152,11,109,112,83,186,2,34,145,64,3,241,103,82,114,198,238,85,84,5,186,202,96,80,210,163,124,135,162,40,32,154,213,118,78,151,239,186,168,157,130,243,159,123,214,253,253,70,135,107,210,146,38,211,102,23,63,155,141,4,25,53,75,89,31,45,102,158,47,59,193,124,51,27,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2811bd82-3edc-4fba-a9ab-749eda63fb70"));
		}

		#endregion

	}

	#endregion

}

