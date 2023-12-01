namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FeatureStateInfoSchema

	/// <exclude/>
	public class FeatureStateInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FeatureStateInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FeatureStateInfoSchema(FeatureStateInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("066f10e1-9d92-46e7-9090-029b9549a7b2");
			Name = "FeatureStateInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73a2a776-4008-4ff0-a541-03cf3c677f19");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,207,78,195,48,12,198,207,155,212,119,136,182,11,92,250,0,76,28,166,161,77,59,20,33,54,196,1,113,112,83,183,178,148,164,83,226,78,2,196,187,227,116,131,238,95,71,111,241,247,125,63,59,78,149,3,139,97,3,26,213,26,189,135,80,151,156,206,106,87,82,213,120,96,170,93,50,252,74,134,131,38,144,171,212,234,35,48,218,201,201,89,252,198,160,142,230,144,46,208,161,39,125,230,121,110,28,147,197,116,37,42,24,250,108,217,103,46,81,183,164,49,171,11,52,87,197,116,42,253,182,255,67,210,87,204,59,195,225,21,173,61,140,158,42,105,134,33,64,37,210,101,143,199,190,250,241,246,122,93,115,4,110,60,174,235,170,50,61,93,100,244,110,78,209,199,30,43,65,170,153,129,16,238,212,158,176,98,96,92,186,178,110,61,111,15,192,32,19,176,7,205,239,82,216,52,185,33,173,116,204,92,136,12,226,227,254,145,231,132,166,16,244,83,27,106,129,59,98,134,54,71,127,243,40,63,139,186,87,35,45,171,29,221,70,252,47,63,176,143,195,207,68,152,244,231,66,108,124,28,36,199,170,157,231,74,12,10,75,238,197,17,47,139,227,240,162,161,34,190,250,180,51,236,49,99,116,197,238,82,114,250,222,173,239,160,148,12,219,154,124,63,6,19,217,143,1,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("066f10e1-9d92-46e7-9090-029b9549a7b2"));
		}

		#endregion

	}

	#endregion

}

