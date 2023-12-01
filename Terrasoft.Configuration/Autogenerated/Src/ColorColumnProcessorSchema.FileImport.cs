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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,75,235,64,16,199,207,10,126,135,161,94,90,144,228,94,219,130,86,148,94,68,176,245,242,120,135,237,102,82,7,146,221,56,187,43,22,241,187,59,217,52,190,38,47,10,246,144,238,14,255,249,207,204,47,19,163,74,116,149,210,8,107,100,86,206,230,62,89,90,147,211,46,176,242,100,77,114,75,5,174,202,202,178,63,59,125,63,59,61,9,142,204,14,30,247,206,99,121,249,117,63,206,102,252,46,158,220,42,237,45,19,58,81,136,230,156,113,39,53,96,89,40,231,166,176,180,133,101,121,132,210,60,176,213,232,156,229,168,75,211,20,102,100,158,145,201,103,86,131,102,204,231,163,53,190,249,158,122,148,46,90,185,11,101,169,120,223,222,175,12,144,113,94,25,25,213,230,224,159,201,129,174,203,130,28,88,24,88,227,104,91,32,228,150,161,106,252,234,1,98,79,160,99,25,120,85,69,64,151,180,37,210,163,26,127,110,48,87,161,240,215,100,50,201,27,251,125,133,54,31,175,122,13,78,46,224,94,144,195,28,140,252,137,96,104,230,201,228,175,56,86,97,91,144,62,52,57,36,131,41,12,32,144,204,247,8,237,31,93,25,205,115,168,201,11,228,135,104,219,40,126,201,245,63,176,49,176,100,84,30,93,23,175,76,47,74,196,131,229,80,251,226,153,124,153,166,125,215,89,165,88,149,145,210,124,20,28,74,182,49,168,235,149,28,45,54,114,151,119,210,6,146,89,26,213,49,249,128,109,168,226,120,211,241,129,174,237,68,120,110,149,195,113,63,92,111,253,201,199,129,41,154,172,193,218,101,44,53,42,100,47,155,61,173,207,94,114,49,251,9,242,181,84,250,5,228,27,229,85,179,126,13,219,96,232,69,206,148,161,241,148,19,242,55,40,171,182,23,176,175,242,41,138,30,238,2,101,209,239,169,182,91,139,219,102,149,193,124,209,141,37,17,96,95,118,57,72,161,97,211,13,74,76,126,159,45,72,20,244,95,4,0,0 };
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

