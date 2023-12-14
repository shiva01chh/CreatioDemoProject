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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,84,77,79,219,64,16,61,27,137,255,48,74,47,77,133,236,158,122,40,193,82,21,16,228,128,84,169,169,56,111,236,73,178,194,187,27,237,7,200,66,252,119,102,118,109,19,66,18,196,161,82,125,242,142,223,155,121,51,111,214,90,40,116,27,81,33,204,209,90,225,204,210,231,83,163,151,114,21,172,240,210,232,124,42,26,212,181,176,238,244,228,233,244,36,11,78,234,21,252,105,157,71,117,190,115,38,102,211,96,197,52,151,95,163,70,43,43,194,16,234,139,197,21,69,97,218,8,231,224,39,220,25,123,79,188,27,19,236,212,4,237,169,184,138,192,162,40,96,226,130,82,194,182,101,119,142,8,240,4,129,69,11,143,137,10,107,226,186,188,167,20,91,156,77,88,52,178,130,42,214,218,87,233,85,192,173,212,193,227,150,132,236,41,202,24,4,223,162,95,155,154,37,255,182,198,83,111,88,39,192,174,208,24,184,70,239,192,175,17,188,84,8,65,75,31,21,190,151,152,34,27,97,133,2,77,22,92,140,106,209,186,81,217,15,27,248,152,79,138,136,216,79,32,220,168,156,83,45,122,121,143,180,232,131,213,174,156,15,66,160,226,46,9,217,127,98,236,166,111,10,204,3,249,47,107,4,73,179,166,62,152,248,151,121,95,103,87,58,40,180,98,209,224,100,214,11,188,20,109,25,69,158,193,165,240,24,203,208,135,49,240,142,100,89,170,1,11,225,48,127,147,44,81,34,146,140,237,146,209,194,57,154,84,50,195,205,52,155,197,187,149,61,119,102,16,42,249,113,208,156,104,249,17,103,168,84,21,26,82,74,162,59,185,180,75,85,39,224,159,153,20,151,116,84,114,67,180,24,134,11,38,25,135,29,27,178,243,14,237,218,149,54,123,240,106,24,253,208,222,135,110,177,189,81,213,62,171,94,211,36,112,4,194,183,163,70,141,183,157,58,116,43,134,73,195,35,226,189,3,161,210,157,54,176,226,223,4,15,228,63,178,224,87,82,103,150,73,237,7,38,116,23,230,142,161,241,79,242,121,15,56,160,210,80,225,98,152,250,143,239,231,251,46,211,86,161,148,174,99,142,143,92,153,20,125,27,164,24,61,47,180,80,208,214,1,6,0,0 };
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

