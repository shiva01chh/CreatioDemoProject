namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastObjectValueAddFromSelectOperationSchema

	/// <exclude/>
	public class IForecastObjectValueAddFromSelectOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastObjectValueAddFromSelectOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastObjectValueAddFromSelectOperationSchema(IForecastObjectValueAddFromSelectOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("215656b7-d84b-1549-3dd0-2a8672dc7856");
			Name = "IForecastObjectValueAddFromSelectOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,221,75,195,48,16,192,159,45,244,127,56,250,164,48,26,240,213,90,112,234,96,79,3,43,123,207,154,235,22,205,71,205,199,116,12,255,119,147,116,29,117,98,200,203,221,229,126,247,75,162,168,68,219,211,22,225,21,141,161,86,119,174,124,212,170,227,91,111,168,227,90,149,11,109,176,165,214,173,111,243,236,152,103,87,222,114,181,133,230,96,29,202,187,115,60,237,54,88,62,205,67,41,20,9,33,80,89,47,37,53,135,250,20,47,149,67,211,197,145,157,54,64,25,139,253,221,105,10,232,205,27,182,14,246,84,120,132,144,211,134,217,114,36,145,9,170,247,27,193,91,224,103,218,114,52,93,37,196,58,18,30,24,91,24,45,27,20,33,179,234,113,184,83,232,62,38,189,63,126,41,1,207,95,216,122,135,209,109,84,0,167,97,194,79,240,151,84,42,207,28,114,9,170,122,106,168,4,21,222,248,190,176,59,68,87,212,35,4,82,92,86,36,157,249,167,37,105,23,245,160,63,131,79,238,118,64,133,8,82,31,158,27,100,208,106,225,165,178,191,48,123,205,25,204,189,120,15,151,31,20,237,117,19,135,13,35,103,48,224,96,160,223,196,63,252,206,179,176,167,235,7,48,67,91,125,24,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("215656b7-d84b-1549-3dd0-2a8672dc7856"));
		}

		#endregion

	}

	#endregion

}

