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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,77,79,219,64,16,134,207,70,226,63,76,77,133,108,20,173,144,122,43,13,61,36,124,168,2,138,228,80,206,139,61,177,87,117,118,221,217,93,212,8,229,191,51,94,59,113,18,84,81,124,155,119,102,158,153,121,215,90,46,208,54,50,71,152,33,145,180,102,238,196,196,232,185,42,61,73,167,140,22,83,44,124,83,171,60,68,135,7,47,135,7,145,183,74,151,144,45,173,195,197,217,94,44,110,148,254,195,34,203,71,132,37,247,192,164,150,214,126,133,105,143,65,155,229,21,67,107,44,50,148,148,87,247,146,120,11,135,52,33,163,47,101,238,12,45,3,160,241,79,220,1,214,241,236,28,242,22,243,81,74,212,238,59,108,98,52,195,180,227,109,238,73,61,51,37,204,137,154,46,128,188,205,131,210,14,166,114,249,115,254,136,248,59,171,12,185,59,38,223,160,46,93,5,99,248,210,93,23,29,161,46,58,110,31,247,67,110,209,85,166,104,71,132,245,251,9,59,167,88,71,173,99,87,232,218,101,47,254,54,132,214,114,111,210,150,70,145,171,212,255,28,10,197,187,37,41,132,251,163,103,73,96,67,138,15,179,124,196,251,173,34,219,212,159,237,49,102,106,129,31,97,180,245,3,163,96,98,231,45,51,46,180,95,8,246,225,151,172,61,218,196,45,27,52,243,100,51,186,171,75,211,206,23,49,145,214,125,219,75,158,39,235,236,99,133,132,73,177,78,192,248,124,235,102,113,45,237,101,45,203,33,159,194,241,49,12,213,159,198,176,71,22,119,70,227,26,158,97,141,185,219,165,111,2,49,51,89,120,210,36,190,138,83,145,249,167,238,133,147,211,209,63,255,164,148,155,30,154,6,41,73,211,206,28,66,231,73,195,231,248,20,94,6,163,197,173,210,158,61,94,237,136,215,198,19,75,223,225,132,229,48,75,252,48,74,39,241,40,30,109,57,156,174,224,36,14,244,213,219,159,182,215,182,37,86,218,239,21,177,25,165,24,22,4,0,0 };
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

