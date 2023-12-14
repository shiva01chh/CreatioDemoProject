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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,142,49,107,195,48,16,133,231,24,252,31,110,235,82,226,61,148,12,49,9,120,11,37,100,63,43,167,34,144,116,226,78,42,24,147,255,94,59,216,52,137,208,242,238,241,125,188,136,129,52,161,33,184,144,8,42,219,188,109,57,90,247,83,4,179,227,184,61,57,79,93,72,44,185,174,198,186,218,52,77,3,95,90,66,64,25,246,75,254,166,36,164,20,179,66,143,74,96,75,52,51,140,222,229,1,44,11,24,246,37,196,15,133,36,108,72,149,101,85,53,79,174,84,122,239,12,184,152,73,236,60,170,59,76,186,246,193,158,87,16,118,208,253,143,106,113,109,62,95,206,66,152,23,242,173,121,182,29,69,88,166,122,137,116,187,162,47,164,83,252,117,55,154,55,142,112,175,171,233,215,213,252,254,0,67,78,69,230,47,1,0,0 };
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

