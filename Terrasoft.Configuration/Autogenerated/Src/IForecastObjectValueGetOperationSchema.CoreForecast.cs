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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,209,107,131,48,16,198,159,45,248,63,28,221,203,6,67,97,143,155,245,101,204,82,24,20,214,209,247,104,47,46,67,19,185,36,131,82,246,191,239,18,107,17,58,168,47,122,95,190,251,252,37,57,45,122,180,131,104,16,62,145,72,88,35,93,246,106,180,84,173,39,225,148,209,89,101,8,27,97,221,254,41,93,156,210,69,226,173,210,45,236,142,214,97,207,214,174,195,38,248,108,182,70,141,164,154,151,116,193,174,59,194,150,85,216,104,135,36,57,255,25,54,83,210,182,254,230,158,189,232,60,174,209,109,7,28,255,20,251,242,60,135,194,250,190,23,116,44,207,245,37,3,164,33,104,209,185,64,32,207,105,96,98,28,252,132,60,96,205,208,193,102,83,84,62,203,26,124,221,169,6,212,37,238,54,81,114,138,84,87,88,81,96,235,109,138,107,140,81,25,4,137,30,52,31,255,106,105,191,16,221,178,220,133,87,145,199,149,255,141,82,117,204,62,222,207,178,172,98,5,77,44,175,250,8,157,39,109,203,119,197,116,168,125,207,155,170,59,4,35,39,188,34,159,60,161,105,243,118,241,20,179,243,248,136,222,50,108,118,252,180,247,145,19,34,244,35,84,51,36,152,243,61,240,32,36,191,227,48,160,62,140,243,16,202,168,241,243,7,146,139,121,54,123,2,0,0 };
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

