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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,193,74,196,48,16,134,207,45,244,29,6,188,232,165,185,235,178,151,21,101,15,138,44,190,64,76,38,221,64,147,41,147,68,40,178,239,110,154,90,173,148,205,33,48,63,51,63,223,63,227,165,195,48,72,133,240,142,204,50,144,137,237,129,188,177,93,98,25,45,249,246,17,117,26,122,171,74,213,212,95,77,221,212,213,13,99,151,75,56,250,136,108,242,248,61,28,95,144,59,60,161,65,70,175,48,60,73,21,137,199,210,46,132,128,93,72,206,73,30,247,63,245,27,211,167,213,24,192,97,60,147,14,96,136,1,125,180,113,4,254,117,1,157,216,250,46,55,101,115,24,152,178,22,218,197,82,172,60,135,244,145,41,193,46,68,215,129,170,156,161,218,48,21,225,132,49,177,15,160,168,239,81,77,137,129,204,26,103,130,220,176,108,97,102,133,103,183,253,225,138,91,187,19,75,203,52,243,159,119,53,244,140,241,47,198,109,136,101,35,65,157,209,201,215,124,191,187,135,178,228,11,228,111,186,13,122,61,159,103,146,47,77,157,223,55,143,117,121,47,231,1,0,0 };
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

