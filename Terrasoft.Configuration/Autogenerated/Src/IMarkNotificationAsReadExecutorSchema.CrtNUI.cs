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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,143,77,10,194,48,16,133,215,22,122,135,1,55,10,210,3,180,43,81,145,46,42,162,189,64,108,166,117,208,36,37,63,98,41,222,221,52,85,233,206,89,205,123,195,247,30,35,153,64,211,178,10,161,68,173,153,81,181,77,54,74,214,212,56,205,44,41,153,28,148,165,154,170,32,76,28,245,113,52,115,134,100,3,231,206,88,20,89,28,121,103,174,177,241,119,200,165,69,93,251,184,20,242,130,233,219,20,94,155,19,50,190,123,98,229,172,210,1,107,221,229,78,21,208,151,250,15,205,250,0,254,10,11,180,87,197,77,10,199,16,53,30,31,138,56,140,12,46,246,206,11,57,137,44,187,22,115,190,130,45,179,88,146,64,208,40,72,242,97,93,102,159,116,148,124,44,240,234,53,126,56,177,226,40,120,195,188,1,134,220,177,83,64,1,0,0 };
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

