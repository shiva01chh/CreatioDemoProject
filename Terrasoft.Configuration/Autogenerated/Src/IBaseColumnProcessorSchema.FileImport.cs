namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBaseColumnProcessorSchema

	/// <exclude/>
	public class IBaseColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBaseColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBaseColumnProcessorSchema(IBaseColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("24ec1cf7-a414-4353-993f-36cb36a92b2f");
			Name = "IBaseColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,142,203,106,195,48,16,69,215,49,248,31,102,151,77,137,247,161,116,17,147,128,119,33,132,238,39,202,168,8,36,141,152,145,2,38,244,223,43,23,155,60,132,54,119,46,231,112,35,6,210,132,134,224,76,34,168,108,243,166,231,104,221,79,17,204,142,227,230,224,60,13,33,177,228,182,185,183,205,170,235,58,248,212,18,2,202,248,53,231,19,37,33,165,152,21,46,168,4,182,68,51,193,232,93,30,193,178,128,97,95,66,92,43,36,97,67,170,44,139,170,123,114,165,114,241,206,128,139,153,196,78,163,134,93,213,245,255,236,113,1,97,11,195,99,84,143,75,243,241,114,22,194,60,147,111,205,179,109,47,194,82,235,57,210,245,27,125,33,173,241,230,174,52,109,188,195,111,219,212,223,54,245,253,1,99,50,120,41,46,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("24ec1cf7-a414-4353-993f-36cb36a92b2f"));
		}

		#endregion

	}

	#endregion

}

