namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMergeReferencesFactorySchema

	/// <exclude/>
	public class IMergeReferencesFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMergeReferencesFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMergeReferencesFactorySchema(IMergeReferencesFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3658508f-d4ef-48d0-af35-afb96664f468");
			Name = "IMergeReferencesFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,193,74,196,48,16,134,207,45,244,29,6,188,232,165,185,235,178,151,21,101,15,138,44,190,64,76,38,221,64,147,148,201,68,40,178,239,110,154,90,173,148,205,33,48,63,51,63,223,63,227,165,195,56,72,133,240,142,68,50,6,195,237,33,120,99,187,68,146,109,240,237,35,234,52,244,86,149,170,169,191,154,186,169,171,27,194,46,151,112,244,140,100,242,248,61,28,95,144,58,60,161,65,66,175,48,62,73,197,129,198,210,46,132,128,93,76,206,73,26,247,63,245,27,133,79,171,49,130,67,62,7,29,193,4,2,244,108,121,4,250,117,1,157,200,250,46,55,101,115,24,40,100,45,182,139,165,88,121,14,233,35,83,130,93,136,174,3,85,57,67,181,97,42,194,9,57,145,143,160,66,223,163,154,18,67,48,107,156,9,114,195,178,133,153,21,154,221,246,135,43,110,237,78,44,45,211,204,127,222,213,208,51,242,95,140,219,200,101,35,81,157,209,201,215,124,191,187,135,178,228,11,228,111,186,13,122,61,159,103,146,47,77,189,126,223,38,240,250,7,240,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3658508f-d4ef-48d0-af35-afb96664f468"));
		}

		#endregion

	}

	#endregion

}

