namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMarkNotificationAsReadExecutorSchema

	/// <exclude/>
	public class IMarkNotificationAsReadExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMarkNotificationAsReadExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMarkNotificationAsReadExecutorSchema(IMarkNotificationAsReadExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5756ae2a-e1ed-46c5-b16e-e91d802e9c2d");
			Name = "IMarkNotificationAsReadExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,143,77,10,194,48,16,133,215,45,244,14,3,110,20,164,7,104,87,162,34,93,84,68,123,129,216,76,235,160,73,74,126,196,82,188,187,49,85,233,206,89,205,123,195,247,30,35,153,64,211,177,26,161,66,173,153,81,141,77,215,74,54,212,58,205,44,41,153,238,149,165,134,234,32,76,18,15,73,28,57,67,178,133,83,111,44,138,60,137,189,51,211,216,250,59,20,210,162,110,124,92,6,69,201,244,117,10,175,204,17,25,223,62,176,118,86,233,128,117,238,124,163,26,232,75,253,135,162,33,128,191,194,18,237,69,113,147,193,33,68,141,199,187,34,14,35,131,243,157,243,66,78,34,171,190,195,130,47,97,195,44,86,36,16,52,10,146,252,189,46,242,79,58,74,62,22,120,245,28,63,156,88,73,28,60,63,47,222,198,37,13,63,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5756ae2a-e1ed-46c5-b16e-e91d802e9c2d"));
		}

		#endregion

	}

	#endregion

}

