namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastObjectValueGetOperationSchema

	/// <exclude/>
	public class IForecastObjectValueGetOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastObjectValueGetOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastObjectValueGetOperationSchema(IForecastObjectValueGetOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8085a14a-5f12-d391-672c-77b5acc1b8d6");
			Name = "IForecastObjectValueGetOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,65,107,132,48,16,133,207,10,254,135,193,94,90,40,10,61,182,174,151,82,23,161,176,208,45,123,143,238,196,166,104,34,147,164,176,44,253,239,77,226,42,194,22,214,139,206,203,155,231,151,100,36,27,80,143,172,69,248,68,34,166,21,55,217,171,146,92,116,150,152,17,74,102,149,34,108,153,54,135,167,36,62,39,113,100,181,144,29,236,79,218,224,224,172,125,143,173,247,233,108,139,18,73,180,47,73,236,92,119,132,157,83,161,150,6,137,187,252,103,168,231,164,93,243,237,122,14,172,183,184,69,179,27,113,250,83,232,203,243,28,10,109,135,129,209,169,188,212,75,6,112,69,208,161,49,158,128,95,210,64,133,56,248,241,121,224,52,69,71,157,205,81,249,42,107,180,77,47,90,16,75,220,109,162,232,28,168,174,176,130,224,172,183,41,174,49,38,101,100,196,6,144,238,248,55,169,254,66,52,105,185,247,175,34,15,43,255,27,185,232,29,251,116,63,105,89,133,10,218,80,94,245,17,26,75,82,151,239,194,209,161,180,131,219,84,211,35,40,62,227,21,249,236,241,77,245,219,226,41,86,231,241,17,188,165,223,236,244,169,239,3,39,4,232,71,168,86,72,176,230,123,112,131,16,253,78,195,128,242,56,205,131,47,131,182,126,254,0,43,0,77,148,132,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8085a14a-5f12-d391-672c-77b5acc1b8d6"));
		}

		#endregion

	}

	#endregion

}

