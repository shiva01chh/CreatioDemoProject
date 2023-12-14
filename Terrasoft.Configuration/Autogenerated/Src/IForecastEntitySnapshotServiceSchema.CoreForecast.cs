namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastEntitySnapshotServiceSchema

	/// <exclude/>
	public class IForecastEntitySnapshotServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastEntitySnapshotServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastEntitySnapshotServiceSchema(IForecastEntitySnapshotServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c7ea9e9-65c5-7705-1050-9886d7a946fc");
			Name = "IForecastEntitySnapshotService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,81,205,74,196,48,16,62,183,208,119,24,234,69,97,105,192,163,174,189,184,46,236,185,226,125,76,167,107,96,147,148,73,90,88,196,119,55,77,54,186,186,130,185,132,76,190,191,153,49,168,201,141,40,9,158,137,25,157,29,124,243,104,205,160,246,19,163,87,214,52,91,203,36,209,249,151,219,170,124,175,202,170,44,174,152,246,225,7,118,198,19,15,129,123,7,187,140,122,50,94,249,99,103,112,116,111,214,119,196,179,146,20,89,66,8,88,187,73,107,228,99,123,122,119,56,19,184,19,24,92,66,195,96,25,40,234,52,153,39,206,136,227,244,122,80,18,84,118,255,215,188,8,177,139,11,255,175,0,238,59,65,143,30,127,217,95,250,167,202,136,140,26,76,24,223,67,157,249,117,155,189,65,147,199,69,173,89,139,136,252,155,56,168,67,104,162,110,183,241,6,249,99,240,231,204,217,170,62,134,205,6,215,185,231,92,216,44,209,115,144,21,36,197,180,73,72,54,55,247,65,233,35,109,144,76,159,150,184,60,99,109,57,159,247,231,137,130,13,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c7ea9e9-65c5-7705-1050-9886d7a946fc"));
		}

		#endregion

	}

	#endregion

}

