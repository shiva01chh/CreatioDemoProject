namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISynchronizationControllerSchema

	/// <exclude/>
	public class ISynchronizationControllerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISynchronizationControllerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISynchronizationControllerSchema(ISynchronizationControllerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d2bb6b3-89a8-4d3d-b77f-083b86d861c6");
			Name = "ISynchronizationController";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,49,110,195,48,12,69,103,27,240,29,8,116,143,247,182,232,18,116,72,215,246,2,180,76,219,2,36,202,32,41,160,73,208,187,151,113,26,32,25,170,237,139,228,251,252,100,204,164,43,6,130,47,18,65,45,147,237,246,133,167,56,87,65,139,133,187,246,220,181,93,219,84,141,60,63,52,9,189,108,149,39,161,217,27,225,192,70,50,57,234,25,14,159,71,14,139,20,142,167,13,226,68,147,146,18,201,54,209,247,61,188,106,205,25,229,248,246,167,247,9,85,73,193,22,52,136,121,77,148,137,237,162,163,66,188,161,33,32,195,64,160,148,40,24,141,128,10,250,232,5,11,242,232,78,186,187,57,245,119,86,107,29,82,12,119,192,255,87,5,207,241,81,134,247,111,10,213,138,111,222,248,37,154,159,107,102,226,241,26,251,34,253,207,223,47,91,109,223,3,75,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d2bb6b3-89a8-4d3d-b77f-083b86d861c6"));
		}

		#endregion

	}

	#endregion

}

