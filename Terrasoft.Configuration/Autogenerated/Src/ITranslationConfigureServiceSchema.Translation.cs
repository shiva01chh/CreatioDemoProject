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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,75,107,131,64,16,62,27,200,127,88,236,37,129,176,222,91,147,67,11,45,41,164,41,49,144,67,200,97,163,163,149,234,174,157,89,3,18,250,223,187,174,143,154,22,210,122,209,253,156,239,177,51,35,69,14,84,136,16,216,22,16,5,169,88,243,7,37,227,52,41,81,232,84,73,190,69,33,41,179,223,227,209,121,60,114,74,74,101,194,130,138,52,228,60,0,60,165,33,172,84,4,217,221,181,159,124,7,71,83,96,74,110,16,18,35,198,150,82,3,198,198,250,150,45,7,38,157,59,180,108,203,241,60,143,249,84,230,185,192,106,209,158,141,201,128,198,66,213,208,24,53,60,222,209,188,1,111,223,138,26,19,141,34,212,147,23,115,127,54,103,238,149,0,238,244,96,152,69,121,204,210,144,165,93,232,63,50,59,103,155,251,87,112,11,60,129,166,46,126,159,62,43,115,73,230,221,42,241,158,237,253,164,251,8,186,68,73,11,159,0,88,136,16,207,47,243,91,169,62,83,180,49,19,86,146,192,245,22,190,215,113,107,177,253,186,0,236,46,96,251,113,176,176,25,213,82,158,212,59,76,86,160,223,84,84,55,232,117,29,108,221,25,219,192,71,9,164,31,21,230,66,27,220,148,174,128,72,36,208,64,252,153,148,156,177,123,21,85,129,174,50,184,40,233,81,190,67,81,20,16,205,106,59,167,203,119,93,212,78,193,249,207,61,235,254,126,163,151,107,210,146,38,211,102,23,63,155,141,4,25,53,75,89,31,45,54,124,190,0,173,84,226,102,36,3,0,0 };
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

