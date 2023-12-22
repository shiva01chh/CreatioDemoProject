﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CurrentUserServiceSchema

	/// <exclude/>
	public class CurrentUserServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CurrentUserServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CurrentUserServiceSchema(CurrentUserServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("88fa4d35-55b7-4ecd-9071-4428ea6d1d0a");
			Name = "CurrentUserService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("90e8157f-4651-4349-83a7-f0455fc70915");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,88,219,110,219,56,16,125,118,129,254,3,225,46,80,5,48,148,247,196,245,34,177,211,198,139,164,113,227,180,1,54,40,22,180,52,182,137,74,148,67,82,105,221,32,255,190,195,139,100,221,172,149,119,95,22,104,30,98,139,156,57,28,158,225,153,161,204,105,12,114,67,3,32,119,32,4,149,201,82,249,227,132,47,217,42,21,84,177,132,191,126,245,252,250,85,47,149,140,175,200,124,43,21,196,167,149,103,255,54,229,138,197,224,207,65,48,26,177,159,198,175,102,133,179,79,44,128,235,36,132,168,117,210,191,135,69,187,193,89,160,216,83,101,149,98,248,2,252,201,249,222,169,11,140,86,49,144,123,13,230,10,255,55,205,98,96,104,17,199,205,235,238,102,179,104,111,147,84,161,13,26,163,249,27,1,43,140,152,140,35,42,229,9,25,167,66,0,87,159,37,8,103,109,172,142,143,143,201,80,166,113,76,197,118,228,158,221,60,89,38,130,172,64,105,72,194,56,62,197,134,3,66,23,184,14,9,44,32,73,17,209,207,144,142,43,80,67,1,248,248,77,142,238,214,76,18,233,128,241,43,13,2,144,146,45,34,187,12,252,80,32,56,141,12,154,28,16,153,16,166,136,92,39,105,20,242,183,74,135,65,208,76,226,7,229,91,252,228,18,57,125,130,98,92,187,32,178,69,113,224,193,109,6,207,152,18,52,80,95,245,216,4,150,52,141,84,129,53,24,144,185,220,20,7,140,225,153,220,124,4,133,36,111,112,133,5,139,152,218,222,194,99,202,112,1,220,186,244,138,15,250,168,144,119,228,31,92,180,149,239,6,194,35,189,200,38,93,68,44,32,129,78,83,67,150,200,9,57,167,18,242,156,245,158,77,222,170,233,213,30,99,220,83,42,96,138,148,88,155,106,114,205,192,236,102,124,227,86,211,204,107,194,223,74,204,166,241,213,12,235,124,75,63,247,47,166,20,169,163,138,22,185,44,135,95,139,162,167,195,237,57,191,107,136,23,32,188,143,88,2,144,168,190,214,240,159,9,199,212,132,208,55,84,228,104,82,9,115,214,11,22,228,89,31,130,83,29,224,41,121,177,251,107,133,213,207,237,176,198,227,80,216,105,88,1,253,144,178,48,135,156,134,157,1,29,227,205,120,25,137,7,195,237,223,245,120,103,112,40,232,21,229,171,148,174,218,129,51,163,206,224,33,85,160,121,123,111,4,220,204,195,164,98,243,47,193,247,179,50,169,217,85,151,232,245,220,58,111,128,135,86,116,101,5,94,131,90,39,33,106,112,102,144,91,164,247,1,203,151,90,67,169,116,22,180,87,169,101,13,242,115,37,21,173,185,28,141,235,110,70,209,213,21,124,93,16,173,139,145,240,205,6,108,171,45,233,248,1,219,201,148,63,37,223,192,179,27,210,44,206,110,230,119,253,1,57,79,194,237,92,109,35,205,44,154,93,99,229,198,68,231,163,254,189,160,155,13,132,3,195,175,46,110,32,149,37,180,228,96,135,252,63,100,194,7,228,22,175,1,9,151,208,110,103,115,246,96,227,63,33,206,96,70,5,38,74,53,136,9,169,112,121,118,105,174,84,36,157,130,66,141,117,51,222,17,177,101,234,137,98,43,146,143,136,200,225,59,49,141,123,59,15,214,216,78,62,165,32,182,158,241,73,56,135,192,36,169,104,112,77,57,70,38,6,164,143,55,136,179,48,102,252,51,103,170,159,33,247,208,213,140,222,178,213,90,73,92,97,73,35,9,150,178,222,116,197,241,10,48,97,114,19,209,237,23,26,33,129,104,161,68,10,102,254,229,212,124,96,100,254,76,48,125,26,76,56,227,36,74,99,238,79,229,23,102,59,169,3,61,205,247,146,215,24,107,138,6,26,227,44,116,207,158,142,213,113,224,107,1,214,60,53,191,29,124,173,190,106,222,89,73,232,128,144,153,214,160,138,93,98,31,206,93,161,54,215,61,247,239,254,33,115,60,209,232,39,59,152,175,126,51,84,27,29,45,96,213,61,85,43,223,62,200,114,113,170,196,84,175,112,29,97,170,209,128,57,197,206,13,245,97,79,117,229,172,15,72,229,236,23,84,132,129,57,56,182,36,94,6,135,26,74,163,40,63,255,86,194,102,204,218,154,210,154,15,163,220,170,82,117,142,133,214,250,206,197,170,163,188,219,98,197,177,59,52,130,25,234,126,49,242,170,73,55,187,61,26,148,161,198,246,170,214,2,102,187,195,14,110,119,250,26,1,93,25,58,0,112,151,175,18,224,174,239,119,216,107,69,221,77,64,221,3,171,9,190,9,46,239,241,135,64,150,171,64,9,182,214,222,59,236,186,89,60,45,176,221,57,216,39,41,11,94,40,197,47,237,77,94,54,117,249,117,130,97,108,52,121,129,126,7,232,208,224,47,203,30,191,64,27,215,28,205,118,23,205,242,85,173,220,186,47,157,105,169,119,107,170,205,41,106,45,86,133,210,247,191,234,245,153,214,40,46,82,223,195,92,191,47,99,182,245,172,127,207,212,250,42,9,104,164,31,145,28,175,127,153,83,87,132,153,42,136,29,185,191,229,38,127,61,91,158,94,250,255,241,118,177,167,223,100,235,248,246,205,238,224,78,99,163,115,126,174,65,88,215,223,219,235,77,65,172,221,100,202,234,74,37,114,203,131,181,72,56,251,9,33,249,142,60,147,171,201,217,172,139,94,135,193,72,167,113,120,28,140,8,118,194,34,208,175,32,94,38,231,133,29,151,37,188,72,146,72,83,62,149,197,95,56,10,230,230,64,135,116,83,146,179,132,8,207,4,98,123,115,243,237,72,43,213,126,173,28,26,91,156,123,61,127,119,181,204,177,13,52,166,176,239,140,252,247,34,137,189,138,116,221,212,253,26,240,117,160,175,111,90,120,242,47,30,83,26,121,78,8,187,13,183,223,132,202,231,214,110,193,191,248,1,65,170,96,142,138,165,98,168,217,24,121,165,51,90,121,185,180,163,229,65,51,86,252,251,27,108,213,101,223,76,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("88fa4d35-55b7-4ecd-9071-4428ea6d1d0a"));
		}

		#endregion

	}

	#endregion

}

