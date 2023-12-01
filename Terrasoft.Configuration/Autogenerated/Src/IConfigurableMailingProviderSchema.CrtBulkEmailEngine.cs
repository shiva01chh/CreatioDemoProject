namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IConfigurableMailingProviderSchema

	/// <exclude/>
	public class IConfigurableMailingProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IConfigurableMailingProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IConfigurableMailingProviderSchema(IConfigurableMailingProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cc13a695-7766-435a-88b7-db1edaea23f9");
			Name = "IConfigurableMailingProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,187,14,194,48,12,69,231,86,234,63,88,98,129,165,221,11,98,97,98,64,98,224,7,66,234,22,75,205,67,78,90,9,33,254,157,168,73,203,99,33,83,124,19,159,28,71,11,133,206,10,137,112,65,102,225,76,235,203,131,209,45,117,3,11,79,70,151,39,65,61,233,174,200,31,69,94,228,217,138,177,11,49,28,181,71,110,67,99,13,199,165,225,218,99,186,126,102,51,82,131,60,245,84,85,5,59,55,40,37,248,190,79,117,186,224,64,161,191,153,198,129,55,32,19,7,65,69,10,216,132,41,103,74,245,129,177,195,181,39,9,52,155,252,17,201,226,0,203,4,167,248,112,13,231,137,19,15,127,85,167,96,198,6,219,32,100,145,61,133,173,105,65,14,204,168,125,80,112,94,104,137,229,130,248,244,204,70,67,205,27,178,222,108,147,8,234,38,186,76,245,51,254,239,87,24,178,176,94,114,136,225,156,165,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cc13a695-7766-435a-88b7-db1edaea23f9"));
		}

		#endregion

	}

	#endregion

}

