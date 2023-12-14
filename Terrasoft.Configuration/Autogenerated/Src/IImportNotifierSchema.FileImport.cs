namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportNotifierSchema

	/// <exclude/>
	public class IImportNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportNotifierSchema(IImportNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d3fe64f7-9465-476a-b7e1-7f9edad4dc1e");
			Name = "IImportNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,207,74,196,48,16,198,207,45,244,29,134,61,173,32,205,3,88,23,68,42,236,101,47,235,11,164,233,180,142,52,127,152,76,11,69,124,119,211,214,93,84,244,96,200,37,51,223,252,230,251,226,180,197,24,180,65,120,70,102,29,125,39,229,163,119,29,245,35,107,33,239,202,39,26,240,104,131,103,41,242,183,34,47,242,44,140,205,64,6,200,9,114,183,140,30,183,254,201,11,117,132,156,36,73,152,101,74,41,168,226,104,173,230,249,112,41,124,138,34,152,129,208,9,200,139,22,160,117,30,210,155,100,6,138,208,32,185,30,162,158,176,45,175,40,245,147,85,5,205,218,130,75,25,238,119,17,93,139,188,59,84,106,173,254,46,194,41,237,120,224,62,126,215,77,158,218,205,217,188,247,205,43,26,129,13,119,11,91,180,122,117,118,214,83,178,85,95,24,112,165,221,220,173,31,243,255,196,41,170,241,54,12,40,127,6,253,226,173,118,237,126,89,149,189,23,121,186,203,249,0,41,224,8,62,192,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3fe64f7-9465-476a-b7e1-7f9edad4dc1e"));
		}

		#endregion

	}

	#endregion

}

