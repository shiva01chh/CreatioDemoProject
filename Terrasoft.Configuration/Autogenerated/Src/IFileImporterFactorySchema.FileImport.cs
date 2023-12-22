namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImporterFactorySchema

	/// <exclude/>
	public class IFileImporterFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImporterFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImporterFactorySchema(IFileImporterFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("03765a8d-a731-806b-9649-74b2d943ce1c");
			Name = "IFileImporterFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,80,187,110,195,48,12,156,99,192,255,64,120,106,151,232,3,234,120,104,128,4,94,139,244,3,88,149,74,5,68,15,144,210,16,20,249,247,74,110,131,216,112,5,45,36,143,119,199,243,232,72,34,106,130,19,49,163,4,147,182,251,224,141,61,103,198,100,131,223,30,236,133,70,23,3,167,182,249,110,155,77,22,235,207,11,52,211,75,219,148,137,82,10,122,201,206,33,95,135,191,250,141,34,147,144,79,2,142,210,87,248,4,19,24,52,19,38,2,83,168,193,78,220,196,119,2,53,99,136,249,227,98,53,88,95,230,166,154,28,31,110,136,15,168,83,224,107,193,85,95,43,249,169,177,255,95,105,45,245,219,137,200,232,192,151,80,118,93,22,226,18,133,39,93,115,232,134,94,77,211,7,152,41,101,246,50,244,66,84,79,50,187,110,124,69,161,185,199,78,149,189,59,176,110,174,16,112,164,52,175,159,222,23,186,176,180,241,92,162,222,220,218,166,252,249,251,1,238,97,178,218,199,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("03765a8d-a731-806b-9649-74b2d943ce1c"));
		}

		#endregion

	}

	#endregion

}

