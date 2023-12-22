namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DuplicatesScheduledSearchParameterCronFactorySchema

	/// <exclude/>
	public class DuplicatesScheduledSearchParameterCronFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DuplicatesScheduledSearchParameterCronFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DuplicatesScheduledSearchParameterCronFactorySchema(DuplicatesScheduledSearchParameterCronFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bafd10b7-77ee-4318-8348-d2d3788c8c67");
			Name = "DuplicatesScheduledSearchParameterCronFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,77,79,219,64,16,134,207,70,226,63,76,77,133,188,40,90,33,245,86,26,122,72,248,80,5,20,201,161,156,23,123,98,175,234,236,186,179,187,168,17,202,127,103,252,145,56,9,170,40,190,205,59,51,207,204,188,107,163,22,232,106,149,33,204,144,72,57,59,247,114,98,205,92,23,129,148,215,214,200,41,230,161,174,116,214,70,135,7,47,135,7,81,112,218,20,144,46,157,199,197,217,94,44,111,180,249,195,34,203,71,132,5,247,192,164,82,206,125,133,105,143,65,151,102,37,67,43,204,83,84,148,149,247,138,120,11,143,52,33,107,46,85,230,45,45,91,64,29,158,184,3,156,231,217,25,100,13,230,163,148,168,217,119,216,196,26,134,25,207,219,220,147,126,102,74,59,39,170,187,0,178,38,15,218,120,152,170,229,207,249,35,226,239,180,180,228,239,152,124,131,166,240,37,140,225,75,119,93,116,132,38,239,184,125,220,15,185,69,95,218,188,25,209,174,223,79,216,57,197,121,106,28,187,66,223,44,123,241,183,38,116,142,123,147,166,52,138,124,169,255,231,80,200,223,45,17,208,222,31,61,43,2,215,166,248,48,199,71,188,223,42,211,77,253,217,30,99,166,23,248,17,70,83,63,48,114,38,118,222,50,227,194,132,133,100,31,126,169,42,160,75,252,178,70,59,79,54,163,187,58,33,58,95,228,68,57,255,109,47,121,158,172,179,143,37,18,38,249,58,1,227,243,173,155,229,181,114,151,149,42,134,188,128,227,99,24,170,63,141,97,143,44,239,172,193,53,60,197,10,51,191,75,223,4,114,102,211,246,73,147,248,42,22,50,13,79,221,11,39,167,163,127,254,73,130,155,30,234,26,41,17,162,51,135,208,7,50,240,57,62,133,151,193,104,121,171,77,96,143,87,59,226,181,13,196,210,119,56,97,185,157,37,127,88,109,146,120,20,143,182,28,22,43,56,137,91,250,234,237,79,219,107,219,18,43,219,223,43,52,144,242,50,30,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bafd10b7-77ee-4318-8348-d2d3788c8c67"));
		}

		#endregion

	}

	#endregion

}

