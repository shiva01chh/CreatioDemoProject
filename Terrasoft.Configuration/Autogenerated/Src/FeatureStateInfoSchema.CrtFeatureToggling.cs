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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,193,110,194,48,12,134,207,32,241,14,17,92,182,75,31,96,104,7,212,9,196,161,211,52,152,118,152,118,48,169,169,44,37,41,74,92,164,109,218,187,207,105,217,104,129,178,222,226,255,255,63,59,78,149,3,139,97,7,26,213,26,189,135,80,110,57,73,75,183,165,162,242,192,84,186,209,240,107,52,28,84,129,92,161,86,31,129,209,78,79,206,226,55,6,117,52,135,100,129,14,61,233,51,207,115,229,152,44,38,43,81,193,208,103,205,62,115,137,186,39,141,89,153,163,185,42,38,51,233,183,255,31,146,188,226,230,104,104,95,209,218,118,244,84,73,50,12,1,10,145,46,123,60,246,213,187,219,235,117,205,17,184,242,184,46,139,194,244,116,145,209,143,115,138,62,241,88,8,82,165,6,66,184,83,7,194,138,129,113,233,182,101,237,121,123,0,6,153,128,61,104,126,151,194,174,218,24,210,74,199,204,133,200,32,62,238,31,121,78,104,114,65,63,213,161,26,216,16,51,180,27,244,55,143,242,179,168,123,53,214,178,218,241,109,196,255,242,3,251,56,124,42,194,180,63,23,98,227,110,144,28,171,122,158,43,49,200,45,185,23,71,188,204,187,225,69,69,121,124,245,217,209,112,192,76,208,229,205,165,228,244,221,172,175,85,26,13,235,90,251,251,1,142,45,63,133,10,3,0,0 };
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

