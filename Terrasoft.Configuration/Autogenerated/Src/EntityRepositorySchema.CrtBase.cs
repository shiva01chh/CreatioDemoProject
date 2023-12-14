﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityRepositorySchema

	/// <exclude/>
	public class EntityRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityRepositorySchema(EntityRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b23c7cd9-c5a7-4736-b607-6b04f9739843");
			Name = "EntityRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,88,75,111,219,70,16,62,43,64,254,195,86,237,129,2,12,170,103,91,18,224,135,108,8,205,171,149,211,28,138,30,214,228,200,218,134,34,229,221,165,28,213,209,127,239,236,131,226,46,69,82,178,35,32,105,128,216,38,185,59,143,111,102,190,153,221,148,46,64,44,105,4,228,22,56,167,34,155,201,240,50,75,103,236,62,231,84,178,44,125,253,234,233,245,171,78,46,88,122,79,166,107,33,97,113,86,121,198,245,73,2,145,90,44,194,27,72,129,179,104,103,205,27,150,62,148,47,93,93,28,154,222,135,227,84,50,201,64,52,46,152,202,198,237,139,69,150,54,238,187,186,192,79,248,241,103,14,247,104,54,185,76,168,16,167,68,235,91,95,81,73,245,215,126,191,79,6,34,95,44,40,95,143,236,179,89,66,98,92,67,162,44,149,156,70,50,44,214,246,157,197,127,77,17,7,154,176,127,233,93,2,127,227,139,101,126,151,176,136,68,74,149,167,169,163,0,222,81,166,95,220,128,20,36,227,68,168,223,114,14,4,140,122,22,171,63,102,12,120,184,221,219,175,110,30,172,104,146,195,246,241,118,207,246,114,181,181,244,38,103,49,153,196,228,137,220,131,60,83,54,156,145,13,126,223,24,232,32,141,13,122,30,146,147,84,2,159,97,62,157,146,9,90,255,7,44,51,193,48,74,107,210,8,233,7,158,173,208,34,65,22,32,231,89,140,142,102,36,187,147,148,165,26,230,90,116,245,11,185,94,194,146,114,186,32,41,102,241,176,123,91,162,218,29,169,159,131,254,118,201,168,140,0,43,76,172,88,56,200,114,73,28,25,26,139,199,57,112,112,223,146,211,157,224,181,135,15,156,140,185,59,52,116,174,91,44,238,142,84,240,24,214,145,187,125,208,223,122,102,54,113,144,57,79,197,200,137,180,6,112,208,47,190,168,165,174,47,104,96,160,195,204,226,222,217,62,71,104,146,120,98,91,204,47,244,149,204,64,178,89,139,77,147,113,154,47,128,171,82,25,184,17,80,138,207,147,36,80,198,213,228,93,167,33,241,140,132,50,178,122,227,110,244,171,203,124,213,213,4,30,188,36,53,26,240,60,143,99,83,207,98,9,145,138,102,124,40,178,110,98,152,45,221,154,120,151,137,177,202,48,186,168,46,112,237,52,139,91,35,254,113,137,162,160,222,200,163,219,103,148,189,212,68,43,250,145,201,121,197,220,111,168,181,150,50,115,215,71,115,154,222,67,252,167,226,78,97,182,70,89,146,47,82,162,233,84,52,250,106,171,238,132,76,174,152,46,16,52,105,32,36,199,102,117,130,236,247,15,86,205,136,120,210,15,199,2,59,102,59,26,226,80,56,62,195,186,44,97,227,30,190,82,46,218,119,199,70,231,34,79,62,91,132,92,78,80,104,141,136,103,205,51,145,107,239,90,182,255,95,210,104,14,113,45,123,212,53,46,167,185,33,187,69,106,51,153,97,183,174,148,242,11,154,151,66,74,45,80,114,229,78,245,120,77,205,24,6,64,19,145,145,136,195,12,69,213,79,114,97,213,177,39,71,231,166,75,250,78,143,52,83,74,61,30,85,154,108,253,190,159,40,79,72,10,143,65,175,224,75,245,191,8,11,78,6,75,224,42,159,79,213,223,18,67,11,177,169,130,101,241,72,76,232,173,64,109,241,13,207,242,229,59,68,181,24,93,76,236,171,193,47,163,143,131,171,228,121,132,198,43,69,26,1,171,197,160,81,143,67,240,81,0,199,189,169,237,112,185,247,120,82,24,102,98,55,69,9,11,170,140,58,81,130,59,29,239,107,228,153,221,67,124,238,168,128,160,42,177,42,170,71,52,100,157,90,223,135,181,178,85,41,116,246,224,241,214,204,97,45,152,103,43,76,49,228,19,139,186,177,232,247,28,176,18,176,103,90,115,182,165,58,22,15,129,111,170,187,1,196,3,218,170,252,13,155,246,106,163,59,108,70,130,58,79,195,137,120,151,39,201,123,254,105,142,35,210,84,29,102,130,94,161,175,99,198,12,165,197,72,217,232,159,248,24,106,41,168,218,15,99,120,190,92,98,204,117,197,232,21,225,39,164,210,55,89,68,19,245,136,49,171,53,194,218,184,149,59,193,97,205,134,225,151,238,83,221,142,141,90,210,53,219,42,70,110,246,224,93,130,188,157,222,172,187,43,202,203,30,48,172,11,70,129,102,161,210,46,14,175,89,26,7,150,103,134,163,162,211,127,224,76,177,214,165,102,109,205,166,225,248,33,71,174,9,80,103,175,41,153,14,34,219,131,105,86,145,33,47,169,246,71,102,216,157,145,114,47,197,238,157,65,143,201,174,110,145,95,51,72,90,107,156,3,141,179,52,89,87,234,163,242,120,214,184,205,173,116,98,126,77,144,103,105,26,193,217,55,242,241,145,152,184,40,154,202,238,97,101,191,169,23,223,131,93,218,112,221,125,75,83,122,143,163,163,170,169,98,199,197,90,169,12,118,108,120,38,33,179,21,206,70,5,230,250,129,232,193,233,154,37,137,49,225,154,103,11,51,247,88,162,178,126,183,15,76,102,32,43,16,193,26,3,36,43,18,40,62,209,159,240,220,84,89,211,177,20,49,5,233,208,67,160,23,133,191,1,234,51,127,234,215,61,135,124,55,190,249,214,200,75,212,40,161,116,225,189,54,204,59,19,168,3,176,223,71,138,178,29,86,18,44,116,165,85,178,195,154,226,3,102,181,21,72,105,77,187,60,185,62,78,247,92,49,46,145,67,15,39,243,23,57,168,218,229,79,54,70,215,32,163,185,242,243,234,66,19,119,17,66,57,231,217,163,98,8,98,46,204,66,221,182,50,121,157,229,105,60,254,18,193,82,183,12,236,96,21,245,186,129,153,67,6,154,252,196,226,77,215,13,113,51,106,77,40,60,99,132,208,176,232,161,65,25,190,179,61,240,77,117,26,179,109,102,122,149,73,89,28,29,206,147,71,186,22,83,80,138,80,36,242,14,28,214,147,11,251,221,12,53,81,49,201,164,224,182,241,241,146,213,117,131,149,116,162,124,113,69,217,8,77,226,237,32,167,198,163,91,108,76,177,83,110,230,100,20,116,39,113,183,103,224,247,140,103,37,225,182,120,80,67,32,182,30,42,4,210,84,140,245,76,160,140,50,165,20,78,226,222,33,73,224,92,23,213,78,46,59,9,208,62,48,150,17,172,155,44,107,171,230,224,218,118,154,210,255,231,234,207,182,207,166,27,192,58,218,41,201,137,197,62,172,13,185,94,94,220,108,209,252,46,87,138,214,215,189,55,139,142,211,28,68,158,72,91,139,111,152,144,222,142,34,171,14,31,177,203,217,58,227,99,108,167,206,120,109,84,133,234,98,174,29,199,158,15,186,217,183,23,220,227,220,47,170,172,107,191,189,179,32,215,94,50,182,117,235,134,102,239,180,221,130,82,232,10,130,25,78,222,176,63,163,142,113,101,249,60,151,107,238,45,93,175,155,10,201,101,196,131,231,144,111,0,228,187,94,144,150,13,97,239,13,96,13,180,135,93,147,58,58,14,37,177,218,121,185,128,221,19,120,28,248,127,156,59,217,23,6,228,104,55,179,53,193,210,163,170,39,35,60,79,215,200,205,95,191,122,235,241,180,157,167,72,208,67,242,107,229,126,199,157,61,85,232,115,109,169,165,114,107,246,199,202,169,176,102,164,181,193,246,142,63,22,30,60,255,212,153,222,49,154,212,236,19,152,239,230,236,99,231,203,15,10,75,144,192,139,143,230,52,228,205,202,86,194,39,117,142,55,147,92,56,73,131,170,0,17,120,0,21,34,236,230,241,23,136,114,244,177,249,74,166,83,123,45,131,111,212,191,255,0,61,120,190,141,6,32,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b23c7cd9-c5a7-4736-b607-6b04f9739843"));
		}

		#endregion

	}

	#endregion

}

