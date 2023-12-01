﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChildImportEntitiesSetterSchema

	/// <exclude/>
	public class ChildImportEntitiesSetterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChildImportEntitiesSetterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChildImportEntitiesSetterSchema(ChildImportEntitiesSetterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8efaed80-f575-470c-9a14-36f2140ff94c");
			Name = "ChildImportEntitiesSetter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,91,111,219,54,20,126,78,129,254,7,214,123,145,1,67,222,115,19,27,72,156,164,8,214,22,65,157,110,15,195,30,100,153,118,184,216,146,75,82,217,140,160,255,125,135,55,137,164,72,75,110,83,172,64,219,135,212,166,14,207,229,59,87,82,46,178,45,102,187,44,199,232,14,83,154,177,114,197,211,89,89,172,200,186,162,25,39,101,145,94,147,13,190,217,238,74,202,95,190,120,122,249,226,164,98,164,88,163,249,158,113,188,61,245,190,195,214,205,6,231,98,31,75,223,224,2,83,146,183,104,222,146,226,83,107,241,14,255,203,155,69,91,23,138,99,235,233,85,193,9,39,152,69,9,174,179,156,151,84,81,0,205,47,20,175,65,53,52,219,100,140,189,70,179,123,178,89,42,211,12,167,57,230,28,83,73,60,30,143,209,25,171,182,219,140,238,167,250,251,121,129,72,193,120,86,0,94,229,10,241,123,194,80,46,152,33,248,64,1,72,176,155,44,54,24,173,74,138,24,240,18,58,237,40,17,60,16,145,146,16,214,162,82,35,99,108,9,249,243,18,175,178,106,195,47,72,177,132,189,9,223,239,112,185,74,110,162,170,14,71,232,61,184,16,77,80,1,255,1,105,156,114,248,23,8,216,85,139,13,201,181,210,81,218,215,40,46,17,152,60,73,128,26,56,193,106,78,43,1,53,160,122,43,37,40,10,31,67,185,48,163,56,227,152,185,72,130,157,64,137,49,202,41,94,77,6,81,233,131,241,52,173,57,143,125,214,103,187,140,102,91,9,197,100,80,49,76,65,181,66,197,227,96,250,17,190,163,188,94,72,207,198,146,58,188,57,47,55,213,182,96,183,180,204,49,99,37,29,76,103,106,5,220,169,151,28,6,26,215,168,222,201,71,71,27,228,42,55,66,55,239,203,226,22,83,70,32,27,10,174,101,157,175,215,0,113,6,184,34,95,159,33,18,185,120,114,226,177,157,120,140,79,37,209,204,219,12,100,62,63,73,248,89,251,21,23,75,229,90,215,207,64,188,195,84,216,244,90,124,230,32,2,47,15,57,186,133,88,216,115,59,195,171,19,133,150,33,79,104,141,249,41,250,124,64,11,223,237,93,58,120,136,122,95,93,129,49,164,222,97,126,95,46,37,76,228,17,130,253,128,122,111,48,103,170,38,236,209,3,222,247,13,110,181,99,48,149,81,182,111,199,50,197,188,162,5,211,207,37,231,179,177,89,84,6,75,205,16,100,174,40,82,160,134,34,253,13,239,19,189,73,201,128,216,188,42,170,45,166,25,20,182,51,69,62,53,241,35,106,15,51,177,56,151,207,46,42,72,1,128,156,45,68,81,194,255,32,103,57,25,170,144,84,34,230,249,61,222,102,202,171,77,235,64,204,90,102,192,69,41,146,42,234,84,175,43,62,80,104,113,150,223,163,68,219,161,244,146,37,145,20,65,45,3,162,29,129,32,207,145,15,125,140,95,236,5,139,164,97,174,173,56,41,23,127,131,206,90,206,239,217,166,194,141,186,176,111,214,172,39,54,83,179,157,45,210,243,221,14,130,40,177,56,232,135,159,229,95,229,50,0,51,189,43,21,144,26,193,67,33,239,197,148,129,65,134,14,235,27,97,75,204,160,125,101,170,118,170,146,166,25,33,235,209,225,42,170,108,54,81,170,113,61,188,133,52,197,115,95,203,197,145,40,143,232,43,97,100,131,233,101,179,132,30,229,90,159,68,241,224,10,167,77,40,39,236,28,154,89,145,151,40,43,212,146,173,147,165,242,8,217,97,169,145,26,169,40,177,250,137,153,34,174,116,106,94,18,153,49,224,196,179,136,144,17,82,49,58,69,45,128,76,70,188,133,114,91,27,129,67,22,232,76,118,8,117,54,129,209,150,180,115,14,79,23,21,199,179,58,85,18,199,74,101,216,80,69,120,172,20,88,229,186,206,73,219,110,145,90,31,240,10,83,12,227,131,162,208,233,165,115,39,104,68,122,190,20,121,230,114,78,173,108,14,249,212,82,222,3,196,53,220,241,119,11,233,145,205,167,75,199,15,89,177,118,80,179,9,244,102,93,22,130,60,250,149,7,139,255,87,215,135,99,242,237,57,74,140,73,200,203,168,13,71,37,109,204,141,42,192,191,42,197,160,121,118,231,190,201,67,237,212,22,19,165,71,250,199,61,4,124,43,182,208,164,45,54,133,136,16,57,34,122,249,16,77,38,14,154,102,125,168,217,206,177,104,187,253,249,206,188,38,216,25,105,246,185,231,168,25,231,7,235,64,55,45,156,186,38,54,187,49,8,159,126,231,125,230,152,249,80,15,86,153,219,79,204,132,101,187,255,26,142,202,231,1,50,195,169,153,177,66,204,52,209,155,138,44,91,93,199,72,115,90,207,173,58,205,187,223,44,122,95,104,144,105,160,225,68,209,187,46,233,60,123,196,173,142,227,60,237,215,114,234,97,89,163,235,111,50,162,72,160,8,233,103,245,20,221,88,24,225,242,76,99,236,178,149,65,234,114,5,36,252,32,157,202,68,198,33,247,255,108,85,62,95,43,207,142,138,177,186,72,24,255,10,55,253,127,29,107,30,105,88,161,192,10,171,222,213,68,58,166,247,47,237,41,38,82,180,160,80,237,213,23,151,125,138,185,84,197,157,125,153,115,27,224,4,158,54,127,98,174,41,82,143,83,122,245,169,202,54,44,216,16,228,96,227,5,92,139,159,36,210,52,215,132,50,222,183,154,41,165,153,115,204,212,245,167,103,136,201,207,152,99,202,234,8,107,150,158,113,176,49,65,51,143,107,28,142,44,171,8,217,97,113,212,12,33,139,157,150,12,21,192,34,49,83,185,226,112,91,91,110,129,96,10,89,96,144,49,65,249,152,81,227,10,143,189,158,73,158,197,136,196,111,187,246,14,147,163,208,107,45,255,233,104,174,187,172,189,67,213,186,60,62,154,136,228,177,7,160,220,185,107,34,43,148,56,155,193,210,106,179,169,69,157,192,164,2,54,152,9,70,55,238,176,242,145,66,208,92,185,165,54,166,141,8,57,102,41,224,63,222,44,189,220,159,155,117,173,128,212,184,38,54,57,107,129,245,161,44,121,189,105,216,72,241,45,49,166,152,161,242,209,158,117,38,173,75,101,137,163,61,201,184,55,24,237,155,58,165,169,203,213,7,55,170,83,160,116,130,78,238,173,115,106,19,189,203,138,108,141,169,104,142,55,250,13,202,197,30,0,104,160,170,213,58,102,30,120,112,243,192,182,236,85,56,85,210,59,186,7,37,236,219,77,96,87,113,159,149,237,153,135,174,108,235,210,51,169,141,59,137,104,37,110,121,140,54,190,38,62,248,15,129,189,142,179,31,219,3,173,222,236,206,181,65,85,58,91,2,136,99,40,23,175,140,156,183,130,189,239,255,137,24,101,205,123,166,111,116,168,13,155,54,112,250,194,210,198,208,121,43,166,123,194,99,9,121,15,214,202,215,99,70,225,196,30,114,149,102,211,26,135,3,69,124,212,26,118,191,162,207,132,205,51,17,91,23,191,166,97,248,253,130,196,188,31,124,223,208,100,120,144,155,152,134,79,159,97,150,143,242,183,142,168,174,113,173,153,58,116,6,108,18,185,79,51,152,4,135,253,83,167,238,169,232,215,159,67,237,172,121,108,39,166,83,120,109,22,175,122,215,93,39,26,247,161,75,234,145,119,7,18,56,49,153,104,13,148,134,99,242,254,231,141,88,156,69,71,161,139,87,152,239,246,58,204,176,63,80,253,188,195,147,45,28,82,72,93,5,249,151,127,95,18,193,7,94,124,196,222,3,69,95,114,117,203,87,118,199,148,168,203,145,243,246,89,212,33,31,21,53,148,184,47,133,173,9,145,213,43,195,174,225,86,227,139,93,100,27,76,205,27,240,32,24,246,96,237,121,200,168,82,239,179,52,113,106,220,161,42,164,54,215,165,110,1,240,60,68,235,76,247,47,17,252,159,229,144,2,206,202,132,47,203,92,255,230,38,254,147,159,193,216,254,141,139,76,53,120,144,28,62,131,245,8,111,129,92,61,248,204,202,170,224,234,14,232,215,26,45,53,95,217,55,137,222,121,36,144,158,222,145,234,42,20,61,241,43,221,190,231,162,111,57,126,160,137,57,47,69,79,193,54,212,206,9,87,107,217,26,182,154,193,202,173,9,145,225,229,180,43,194,212,170,187,8,107,240,239,63,61,16,17,170,83,40,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8efaed80-f575-470c-9a14-36f2140ff94c"));
		}

		#endregion

	}

	#endregion

}
