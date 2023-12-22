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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,142,49,107,195,48,16,133,231,24,252,31,110,235,82,226,61,132,14,49,13,120,11,33,100,63,203,167,34,144,116,226,78,10,132,144,255,30,187,216,212,141,208,242,238,241,125,188,136,129,52,161,33,184,144,8,42,219,188,109,57,90,247,83,4,179,227,184,61,58,79,93,72,44,185,174,30,117,181,105,154,6,246,90,66,64,185,127,205,249,76,73,72,41,102,133,30,149,192,150,104,38,24,189,203,119,176,44,96,216,151,16,63,20,146,176,33,85,150,69,213,172,92,169,244,222,25,112,49,147,216,105,84,119,24,117,237,47,123,90,64,216,65,247,55,170,197,165,249,252,119,22,194,60,147,111,205,218,246,45,194,50,214,115,164,225,138,190,144,142,241,230,6,154,54,62,224,89,87,227,175,171,245,123,1,132,161,142,136,55,1,0,0 };
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

