namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IStartDeduplicationRequestFactorySchema

	/// <exclude/>
	public class IStartDeduplicationRequestFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IStartDeduplicationRequestFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IStartDeduplicationRequestFactorySchema(IStartDeduplicationRequestFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("317ae3ca-74ff-401a-9e48-5d31d65af269");
			Name = "IStartDeduplicationRequestFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,77,75,195,64,16,134,207,45,228,63,12,245,162,32,201,93,107,65,171,66,46,34,173,224,121,155,157,212,165,201,110,156,217,21,139,248,223,221,143,182,54,180,69,115,202,59,51,239,187,207,126,104,209,34,119,162,66,120,65,34,193,166,182,249,212,232,90,45,29,9,171,140,206,239,81,186,174,81,85,84,217,240,43,27,14,28,43,189,132,94,227,161,17,108,85,149,191,226,226,182,83,33,194,146,168,44,231,51,124,119,200,150,175,179,161,119,158,17,46,253,52,148,218,34,213,126,217,43,40,239,92,179,234,101,205,92,131,143,222,108,104,29,77,69,81,192,152,93,219,10,90,79,54,250,153,204,135,146,200,208,162,125,51,18,106,67,176,112,170,145,129,140,173,32,235,101,179,2,185,31,12,148,96,242,109,104,177,151,218,185,133,159,3,181,37,131,114,30,98,250,100,201,191,131,27,132,211,56,224,139,133,41,161,176,158,239,63,44,135,48,169,210,9,18,45,104,127,69,55,35,198,42,216,158,188,24,77,230,73,196,86,62,46,226,220,113,155,210,18,63,147,169,12,191,39,44,132,214,145,230,201,252,47,218,113,177,29,13,222,147,39,180,217,254,201,254,57,91,138,55,245,187,171,75,216,212,118,200,23,254,205,12,190,211,187,65,45,211,211,9,50,214,194,247,3,204,49,250,123,190,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("317ae3ca-74ff-401a-9e48-5d31d65af269"));
		}

		#endregion

	}

	#endregion

}

