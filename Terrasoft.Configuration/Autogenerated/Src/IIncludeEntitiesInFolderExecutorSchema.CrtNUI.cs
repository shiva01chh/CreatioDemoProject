namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IIncludeEntitiesInFolderExecutorSchema

	/// <exclude/>
	public class IIncludeEntitiesInFolderExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IIncludeEntitiesInFolderExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IIncludeEntitiesInFolderExecutorSchema(IIncludeEntitiesInFolderExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fc490832-b2c8-4995-9b6d-4c38bf371f49");
			Name = "IIncludeEntitiesInFolderExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,65,75,3,49,16,133,207,22,250,31,134,122,177,151,205,93,215,66,41,21,246,222,155,120,136,201,100,9,100,39,203,100,2,150,210,255,222,52,187,85,81,193,220,222,100,222,155,143,71,122,192,52,106,131,112,64,102,157,162,147,102,23,201,249,62,179,22,31,9,78,203,197,114,113,119,207,216,95,149,39,65,118,101,255,17,186,142,76,200,22,247,36,94,60,166,142,94,98,176,200,251,15,52,89,34,87,159,82,10,218,148,135,65,243,113,51,235,238,150,81,210,106,2,224,28,1,18,193,213,144,212,220,204,234,155,123,204,239,193,155,47,136,127,25,102,250,95,24,117,176,181,22,18,6,52,130,246,15,132,230,211,168,126,58,219,81,179,30,128,74,121,207,43,231,67,193,73,83,107,171,77,171,234,103,221,45,160,48,161,224,67,18,246,212,191,190,1,163,137,108,211,33,150,251,235,167,178,118,158,26,70,178,83,201,87,89,103,229,93,0,196,83,109,205,160,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fc490832-b2c8-4995-9b6d-4c38bf371f49"));
		}

		#endregion

	}

	#endregion

}

