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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,65,75,3,49,16,133,207,22,250,31,134,122,209,203,230,222,174,5,145,10,123,239,77,122,72,147,201,18,200,78,150,153,4,90,196,255,110,154,221,106,81,193,220,222,100,222,155,143,71,122,64,25,181,65,216,35,179,150,232,82,243,18,201,249,62,179,78,62,18,188,47,23,203,197,221,61,99,127,81,158,18,178,43,251,107,232,58,50,33,91,220,81,242,201,163,116,244,26,131,69,222,157,208,228,20,185,250,148,82,208,74,30,6,205,231,237,172,187,107,70,73,171,9,128,115,4,164,8,174,134,72,115,53,171,27,247,152,143,193,155,111,136,127,25,102,250,95,24,117,240,108,45,8,6,52,9,237,31,8,205,151,81,253,116,182,163,102,61,0,149,242,158,86,206,135,130,35,83,107,171,109,171,234,103,221,45,160,48,161,224,131,36,246,212,191,29,128,209,68,182,178,143,229,254,227,166,172,125,76,13,35,217,169,228,139,172,179,219,247,9,121,4,57,172,169,1,0,0 };
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

