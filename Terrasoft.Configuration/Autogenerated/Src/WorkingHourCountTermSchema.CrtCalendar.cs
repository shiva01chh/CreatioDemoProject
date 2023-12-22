namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WorkingHourCountTermSchema

	/// <exclude/>
	public class WorkingHourCountTermSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WorkingHourCountTermSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WorkingHourCountTermSchema(WorkingHourCountTermSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5cacbc39-30b4-4a81-96b8-4533327f7a02");
			Name = "WorkingHourCountTerm";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,84,77,107,219,64,16,61,43,144,255,48,184,151,186,4,169,167,30,26,71,80,156,144,250,16,40,212,37,231,181,52,182,151,104,119,205,126,52,136,208,255,222,153,93,73,81,28,219,33,135,66,117,210,142,222,155,121,51,111,86,90,40,116,59,81,33,44,209,90,225,204,218,231,115,163,215,114,19,172,240,210,232,124,46,26,212,181,176,238,252,236,233,252,44,11,78,234,13,252,108,157,71,117,185,119,38,102,211,96,197,52,151,223,162,70,43,43,194,16,234,131,197,13,69,97,222,8,231,224,43,220,27,251,64,188,239,38,216,185,9,218,83,113,21,129,69,81,192,204,5,165,132,109,203,238,28,17,224,9,2,171,22,30,19,21,182,196,117,121,79,41,70,156,93,88,53,178,130,42,214,58,84,233,89,192,157,212,193,227,72,66,246,20,101,12,130,239,208,111,77,205,146,127,88,227,169,55,172,19,96,95,104,12,220,162,119,224,183,8,94,42,132,160,165,143,10,95,75,76,145,157,176,66,129,38,11,174,38,181,104,221,164,236,135,13,124,204,103,69,68,28,38,16,110,82,46,169,22,189,188,70,90,244,193,106,87,46,7,33,80,113,151,132,236,63,49,118,215,55,5,230,55,249,47,107,4,73,179,166,62,152,248,139,121,31,23,55,58,40,180,98,213,224,108,209,11,188,22,109,25,69,94,192,181,240,24,203,208,135,41,240,142,100,89,170,1,43,225,48,127,145,44,81,34,146,140,237,146,209,194,57,154,84,50,195,45,52,155,197,187,149,253,233,204,32,84,242,227,168,57,209,242,19,206,80,169,42,52,164,148,68,119,114,105,151,170,78,192,63,51,41,46,233,164,228,134,104,49,12,23,76,50,142,59,54,100,231,29,218,183,43,109,246,224,213,48,250,161,189,55,221,98,123,163,170,67,86,61,167,73,224,8,132,79,39,141,154,142,157,58,118,43,134,73,195,35,226,131,3,161,210,157,54,176,225,223,4,15,228,63,178,224,91,82,103,214,73,237,27,38,116,23,230,158,161,241,79,242,126,15,56,160,210,80,225,106,152,250,151,207,151,135,46,211,168,80,74,215,49,167,39,174,76,138,190,12,82,108,244,252,5,50,100,75,166,9,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5cacbc39-30b4-4a81-96b8-4533327f7a02"));
		}

		#endregion

	}

	#endregion

}

