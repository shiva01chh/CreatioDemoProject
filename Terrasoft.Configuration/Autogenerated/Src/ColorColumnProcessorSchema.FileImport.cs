namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColorColumnProcessorSchema

	/// <exclude/>
	public class ColorColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColorColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColorColumnProcessorSchema(ColorColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ece3bf3e-1c9f-4ab6-ae57-035b0707f269");
			Name = "ColorColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,75,235,64,16,199,207,10,126,135,161,94,90,120,36,247,218,22,180,226,163,151,135,96,235,69,60,108,55,147,186,144,236,230,205,206,138,69,252,238,78,54,141,54,49,10,246,144,238,14,255,249,207,204,47,19,171,74,244,149,210,8,107,36,82,222,229,156,44,157,205,205,46,144,98,227,108,114,99,10,92,149,149,35,62,59,125,61,59,61,9,222,216,29,220,237,61,99,121,241,113,63,206,38,252,46,158,220,40,205,142,12,122,81,136,230,156,112,39,53,96,89,40,239,167,176,116,133,35,121,132,210,222,146,211,232,189,163,168,75,211,20,102,198,62,33,25,206,156,6,77,152,207,71,107,124,225,158,122,148,46,90,185,15,101,169,104,223,222,47,45,24,235,89,89,25,213,229,192,79,198,131,174,203,130,28,72,24,56,235,205,182,64,200,29,65,213,248,213,3,196,158,64,199,50,240,172,138,128,62,105,75,164,71,53,30,174,49,87,161,224,43,99,51,201,27,243,190,66,151,143,87,189,6,39,127,224,159,32,135,57,88,249,19,193,208,204,147,201,163,56,86,97,91,24,125,104,114,72,6,83,24,64,32,153,175,17,218,39,93,25,141,41,212,228,5,242,109,180,109,20,191,228,250,5,108,12,44,9,21,163,239,226,149,233,69,137,120,176,28,106,95,60,147,15,211,180,239,58,171,20,169,50,82,154,143,130,71,201,182,22,117,189,146,163,197,70,238,242,78,218,64,50,75,163,58,38,31,176,13,85,28,111,58,62,208,181,157,8,207,173,242,56,238,135,235,173,63,121,59,48,69,155,53,88,187,140,165,70,133,196,178,217,211,250,204,146,139,217,79,144,175,164,210,47,32,95,43,86,205,250,53,108,131,53,255,229,108,50,180,108,114,131,244,13,202,170,237,5,220,179,124,138,162,135,191,193,100,209,239,190,182,91,139,219,102,149,193,124,209,141,37,17,96,95,118,49,72,161,97,211,13,74,236,248,247,14,41,221,248,65,104,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ece3bf3e-1c9f-4ab6-ae57-035b0707f269"));
		}

		#endregion

	}

	#endregion

}

