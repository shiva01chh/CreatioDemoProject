﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TemplateSizeValidatorSchema

	/// <exclude/>
	public class TemplateSizeValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TemplateSizeValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TemplateSizeValidatorSchema(TemplateSizeValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("718a1316-d979-40f0-b019-f35f1fff0f3b");
			Name = "TemplateSizeValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,88,91,111,219,54,20,126,118,129,253,7,78,123,168,140,26,114,27,116,64,81,199,46,114,237,188,197,75,144,164,217,195,58,20,140,68,219,92,37,210,35,41,55,105,144,255,190,195,139,36,74,150,108,111,125,105,68,242,220,62,158,243,157,67,51,156,17,185,194,49,65,183,68,8,44,249,92,69,39,156,205,233,34,23,88,81,206,126,120,241,244,195,139,94,46,41,91,160,155,71,169,72,54,106,124,195,249,52,37,177,62,44,163,143,132,17,65,227,141,51,23,148,253,83,45,250,182,178,140,179,246,29,207,139,104,134,105,10,251,187,15,126,82,52,149,237,199,4,137,206,113,172,184,160,68,159,128,51,63,9,178,0,33,116,146,98,41,223,195,225,108,149,98,69,110,232,119,114,135,83,154,96,56,108,14,14,135,67,116,40,243,44,195,226,113,226,190,103,152,225,5,145,104,109,79,106,61,124,142,0,78,105,150,149,83,134,36,104,139,10,29,67,79,201,42,191,79,105,140,98,109,188,221,54,122,143,142,177,36,51,171,211,115,169,247,100,220,170,2,0,236,21,102,10,130,184,18,116,13,122,236,254,202,126,160,88,239,35,202,20,114,64,206,240,131,111,113,202,142,31,21,56,61,70,63,31,188,61,120,247,238,245,200,233,39,44,177,38,234,246,206,41,73,147,46,99,199,121,250,245,44,3,59,51,28,11,126,133,133,36,2,125,185,111,89,29,213,5,79,206,110,156,123,133,111,246,190,30,209,23,85,95,216,225,222,149,224,43,34,20,220,51,184,104,80,182,251,205,107,52,11,31,137,130,219,90,146,234,198,230,214,72,84,138,248,183,86,92,91,183,179,205,239,177,17,235,53,99,64,31,62,160,112,99,113,140,24,249,214,173,60,236,247,71,187,98,129,188,145,69,76,26,117,68,52,236,40,211,184,163,149,1,126,123,104,173,23,216,186,248,100,34,91,16,5,65,182,95,177,141,178,117,103,172,221,245,22,108,108,160,79,110,211,55,214,5,151,19,115,242,249,63,164,129,224,10,72,138,36,251,162,199,128,25,117,65,195,37,124,37,9,34,76,81,245,136,100,188,4,52,187,224,43,108,32,169,132,102,159,11,35,123,102,68,111,140,228,239,90,235,19,2,196,70,218,204,8,61,239,147,153,43,46,37,189,135,124,0,15,20,215,117,12,180,150,175,20,138,151,152,26,218,89,23,220,32,119,250,198,215,32,76,19,200,13,206,83,52,149,71,247,92,168,75,118,87,209,24,96,63,199,169,36,59,170,108,70,212,146,119,178,64,194,33,153,136,102,38,176,167,12,189,220,242,25,89,224,123,253,103,168,185,72,86,204,211,119,169,36,136,202,5,168,198,106,25,93,243,156,37,161,119,8,13,209,155,215,7,111,231,197,255,3,116,208,247,243,160,48,173,117,3,118,62,193,133,211,70,61,149,213,94,88,94,99,129,104,102,168,123,92,110,70,83,6,66,100,106,214,163,91,14,117,105,254,14,251,240,113,65,165,10,93,202,106,105,229,217,3,29,112,86,55,35,170,243,47,106,186,83,26,0,124,20,228,214,192,217,118,234,28,12,190,198,182,64,91,107,178,89,84,94,124,134,2,228,47,36,93,153,66,50,109,207,17,139,246,240,112,230,237,223,29,76,138,224,124,177,232,19,40,5,167,153,237,248,160,165,190,80,193,209,81,189,27,70,219,130,152,132,70,77,207,112,161,238,93,34,215,2,71,98,145,103,128,86,24,248,46,5,131,90,96,253,193,14,217,180,181,42,65,75,123,185,246,235,119,210,209,199,54,238,230,148,26,60,160,254,14,45,27,12,116,94,78,244,245,92,66,69,232,180,78,138,148,144,97,9,66,165,223,191,184,34,17,170,81,203,53,10,157,131,135,205,220,158,248,89,73,153,225,134,98,79,71,36,157,112,135,139,133,52,157,163,240,199,210,157,232,40,79,40,97,49,177,200,76,147,104,42,207,178,149,210,45,201,121,218,155,50,170,218,65,12,187,245,56,107,207,27,193,94,147,21,116,35,172,189,109,116,193,232,68,16,248,58,61,169,0,172,103,225,160,130,113,208,90,37,94,136,155,230,0,157,60,45,241,47,46,94,175,249,174,110,222,73,116,148,36,215,152,45,200,134,78,103,110,14,51,40,142,151,40,180,197,88,39,36,202,90,174,185,116,66,123,234,40,154,212,152,164,161,102,128,120,174,80,147,142,170,43,234,193,40,168,40,115,13,180,136,165,134,187,233,81,99,215,195,52,65,197,24,170,230,115,16,120,168,70,250,208,0,233,85,23,91,175,45,209,52,34,161,175,119,80,119,107,84,67,184,77,131,143,248,174,99,141,10,116,77,216,163,222,170,199,157,61,196,100,165,255,112,179,117,232,14,167,241,247,43,172,160,189,66,10,117,85,112,9,130,244,75,212,12,89,178,194,237,87,78,89,8,144,249,168,201,232,55,242,88,36,131,179,232,30,12,3,36,136,204,83,53,242,200,250,193,142,230,101,211,212,236,217,209,78,183,142,245,94,178,123,174,156,64,123,85,58,217,223,148,201,209,76,155,253,108,123,58,239,244,104,38,163,115,42,164,186,20,167,100,142,33,164,114,174,235,185,88,237,228,119,17,127,191,49,16,24,33,119,1,209,57,23,25,164,155,127,15,193,13,108,228,41,22,65,191,74,24,141,85,5,182,147,42,177,236,8,98,208,2,106,65,63,136,192,196,83,0,241,63,29,189,74,225,25,154,238,239,166,205,153,109,94,249,121,239,37,72,35,211,215,156,38,104,11,249,126,204,97,31,55,121,215,75,222,250,158,107,15,37,111,214,25,187,65,181,206,211,186,134,232,156,168,120,121,46,120,118,122,28,6,211,4,138,160,105,126,160,109,252,249,23,12,195,129,245,247,242,254,111,208,24,160,103,167,177,99,120,110,14,28,145,127,194,190,201,133,69,95,79,23,83,243,46,142,201,241,227,167,105,18,54,156,244,237,2,30,134,211,246,121,87,120,131,239,238,71,69,65,218,141,95,4,244,208,238,63,206,108,74,116,12,239,102,5,94,110,56,51,207,146,113,96,132,204,232,248,160,130,201,41,188,9,190,81,181,4,68,99,173,7,158,145,158,106,202,230,252,112,104,164,43,101,54,165,228,196,155,250,139,156,7,154,96,28,134,243,60,142,9,73,162,195,97,113,182,227,25,225,120,172,136,179,26,101,156,127,200,119,214,79,186,102,117,152,105,162,115,112,217,115,104,113,45,214,118,88,27,209,52,209,189,213,247,34,154,21,59,178,198,125,37,147,217,194,47,35,113,137,92,234,43,234,91,203,240,141,97,206,10,183,12,121,213,104,87,180,204,121,216,38,222,152,63,10,26,121,213,228,145,77,110,10,74,246,199,107,146,120,237,78,8,14,244,233,38,227,94,79,247,109,244,170,209,206,97,193,239,231,158,217,151,159,217,203,98,94,168,241,100,179,233,203,106,4,218,12,172,95,27,57,158,93,79,10,55,85,48,127,166,172,188,216,175,145,7,126,3,172,206,61,189,126,254,3,11,6,72,5,131,141,212,218,143,109,119,211,193,174,159,154,60,46,88,86,52,224,255,246,180,47,1,20,231,131,201,173,47,189,81,231,109,50,26,152,96,114,109,113,109,117,162,147,46,26,100,96,127,46,50,191,35,180,206,166,157,143,110,59,165,234,119,122,109,28,116,119,222,120,72,119,189,157,187,223,202,232,112,188,253,135,206,45,215,106,87,235,139,176,6,255,254,5,136,142,143,91,44,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("718a1316-d979-40f0-b019-f35f1fff0f3b"));
		}

		#endregion

	}

	#endregion

}

