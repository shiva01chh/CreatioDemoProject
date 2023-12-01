﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityUtilsServiceSchema

	/// <exclude/>
	public class EntityUtilsServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityUtilsServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityUtilsServiceSchema(EntityUtilsServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3840c26f-96f8-4ffa-af38-ec8670359a54");
			Name = "EntityUtilsService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eef46199-fd2a-476e-ade8-8bc800e7efdf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,86,77,111,227,54,16,61,123,129,253,15,3,247,162,0,134,124,79,28,3,73,218,164,110,155,77,176,78,186,135,96,15,180,52,182,217,72,164,74,82,9,212,69,254,123,103,72,73,150,229,143,13,176,167,205,37,22,57,243,102,230,113,230,145,74,228,104,11,145,32,60,160,49,194,234,165,139,175,180,90,202,85,105,132,147,90,125,252,240,237,227,135,65,105,165,90,193,188,178,14,243,179,222,55,217,103,25,38,108,108,227,27,84,104,100,178,99,51,71,243,34,19,188,213,41,102,71,55,227,11,66,122,241,161,143,219,125,193,197,198,160,155,188,193,248,55,229,164,147,104,15,26,92,139,196,105,115,192,130,144,201,42,207,125,6,180,255,139,193,21,165,3,87,153,176,246,20,60,120,245,232,100,102,235,132,188,213,120,60,134,137,45,243,92,152,106,90,127,179,17,217,130,13,118,144,48,2,44,181,129,87,109,158,57,234,171,116,107,114,67,218,51,184,60,31,6,240,225,120,26,55,144,227,14,230,83,29,144,78,200,25,42,225,43,175,93,216,226,19,58,74,184,32,214,22,62,224,103,252,183,148,6,115,84,206,70,221,15,166,14,206,225,59,46,108,21,215,11,233,9,7,41,202,69,38,147,58,255,93,2,224,20,46,133,197,150,142,193,55,79,73,203,220,45,186,181,78,137,187,123,195,103,27,8,219,97,204,47,204,20,157,156,200,228,127,104,65,128,194,87,144,202,58,161,40,136,94,130,91,227,46,91,221,76,136,185,144,101,220,70,24,247,67,76,12,186,210,40,59,189,248,17,252,201,184,129,97,220,34,20,214,229,230,119,204,10,52,112,131,110,103,49,58,1,158,170,193,32,64,132,206,10,61,89,209,8,185,201,142,199,52,226,84,233,220,173,51,37,219,93,152,85,201,135,21,13,75,234,46,218,80,97,4,135,35,120,220,90,56,57,225,30,31,188,213,39,130,42,13,135,114,232,132,252,73,31,57,160,43,93,72,62,27,149,66,38,213,179,133,84,56,1,78,123,238,108,129,137,92,74,76,1,125,5,48,41,132,17,57,145,9,138,148,230,124,104,104,159,252,85,205,201,44,101,66,151,70,231,193,93,151,198,247,79,8,221,243,13,187,29,199,99,103,236,125,247,59,78,31,218,80,32,211,17,188,174,101,178,134,68,23,85,168,69,90,95,25,21,193,211,73,7,237,177,246,67,239,214,227,209,219,229,78,0,143,253,42,179,12,22,216,4,112,250,56,124,162,179,50,87,159,232,119,192,13,223,126,211,203,8,195,52,50,242,30,218,230,201,26,115,193,120,150,249,59,26,27,123,30,195,105,192,8,209,105,88,106,10,185,19,218,122,143,67,30,74,101,250,151,180,142,33,235,174,177,126,207,59,217,81,104,143,61,28,38,220,137,233,241,136,82,17,69,56,75,59,49,100,26,36,56,108,129,112,78,36,107,175,123,223,129,178,119,42,171,102,222,107,56,189,206,196,138,122,86,56,198,74,104,32,104,2,124,11,105,50,122,23,118,35,31,161,95,108,153,249,236,24,131,78,180,39,47,79,119,164,1,254,82,236,74,255,224,137,174,170,153,122,209,207,24,133,1,38,109,31,222,223,205,31,72,5,46,117,90,205,93,149,177,222,147,217,45,90,43,86,216,174,198,95,140,40,10,76,71,94,135,88,236,209,186,107,109,114,170,168,235,16,150,226,63,172,86,35,248,76,111,5,146,32,60,110,231,111,140,230,202,248,85,122,21,162,217,156,144,116,81,101,35,8,255,167,172,36,85,115,83,71,55,165,76,97,123,80,71,224,23,119,70,172,65,128,205,116,132,42,234,229,126,227,142,128,143,126,210,132,61,208,132,181,149,94,252,67,186,57,133,182,113,168,74,85,102,217,8,124,136,133,214,25,116,59,129,182,151,34,179,216,40,250,96,247,6,88,135,127,231,7,174,130,179,224,119,132,168,156,78,138,126,132,100,2,90,204,228,69,125,190,246,80,213,231,104,48,216,165,231,32,35,45,9,163,173,154,155,148,235,219,107,147,94,247,166,217,123,121,16,3,214,43,125,45,100,244,254,88,91,88,84,144,163,19,247,244,1,47,34,163,78,124,175,178,7,152,219,218,217,110,137,36,67,134,0,135,103,111,67,58,171,52,26,132,103,172,248,2,232,96,248,180,72,47,182,181,169,100,97,247,201,118,204,139,45,211,38,90,71,205,126,254,177,126,10,249,159,66,109,112,207,196,162,163,70,230,158,225,68,3,23,225,60,222,43,5,55,252,26,109,221,46,84,26,154,209,183,97,212,241,187,241,180,119,199,121,10,189,30,104,6,241,69,24,150,85,95,24,207,48,61,159,14,39,208,76,97,119,6,110,133,162,250,204,150,156,52,107,231,189,71,86,188,199,49,32,210,237,128,116,7,64,244,39,86,127,115,187,220,11,105,246,214,241,220,49,160,201,59,84,215,192,139,98,55,169,199,25,55,72,215,61,166,96,103,93,57,10,134,91,94,228,178,167,50,126,125,206,234,7,241,101,69,200,81,47,210,102,246,3,181,79,189,253,248,65,207,125,69,209,201,215,94,136,152,143,179,118,223,82,228,102,202,108,191,12,255,171,246,104,137,172,85,190,29,77,185,25,211,13,73,131,173,43,194,219,245,146,161,66,195,175,77,227,93,86,13,219,81,131,216,148,187,169,183,217,225,234,54,232,181,217,155,255,247,214,125,219,55,142,71,94,225,97,117,123,209,175,209,223,255,225,180,246,134,161,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3840c26f-96f8-4ffa-af38-ec8670359a54"));
		}

		#endregion

	}

	#endregion

}
