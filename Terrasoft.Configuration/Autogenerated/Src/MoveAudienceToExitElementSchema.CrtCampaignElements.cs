﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MoveAudienceToExitElementSchema

	/// <exclude/>
	public class MoveAudienceToExitElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MoveAudienceToExitElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MoveAudienceToExitElementSchema(MoveAudienceToExitElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d93ec393-d854-4c31-8744-226d42cd33ec");
			Name = "MoveAudienceToExitElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,87,221,111,26,71,16,127,38,82,254,135,17,125,136,45,97,104,162,184,36,182,161,178,193,184,72,117,100,37,78,95,162,62,44,123,3,108,117,220,158,118,247,236,16,203,255,123,103,63,238,184,3,31,224,202,149,170,242,128,238,102,103,231,227,247,155,157,217,75,216,2,117,202,56,194,45,42,197,180,156,154,246,64,38,83,49,203,20,51,66,38,175,95,61,188,126,213,200,180,72,102,240,101,169,13,46,78,215,222,73,63,142,145,91,101,221,190,194,4,149,224,43,157,178,89,133,117,242,246,128,45,82,38,102,201,78,133,246,56,49,168,166,20,177,174,213,189,81,146,150,237,58,105,252,164,112,70,161,193,32,102,90,159,192,181,188,195,243,44,18,152,112,188,149,151,223,133,185,140,113,129,137,113,202,157,78,7,206,116,182,88,48,181,236,135,247,176,14,102,206,12,44,104,187,134,148,41,35,184,72,89,98,52,24,9,60,83,202,170,240,16,36,8,194,5,38,75,208,41,114,49,21,24,193,84,198,17,170,118,238,163,83,114,242,109,136,154,54,93,203,8,41,242,20,149,89,30,124,34,94,160,7,205,177,206,19,191,146,44,110,182,72,189,241,85,179,25,222,46,83,171,176,218,90,72,219,159,164,249,67,104,49,137,177,5,215,104,88,110,52,216,172,154,44,47,30,254,73,230,211,108,18,11,14,220,194,85,143,22,156,192,5,211,152,91,202,117,194,106,11,198,225,233,70,9,169,132,89,146,225,7,135,240,138,15,42,23,99,1,60,1,82,186,99,6,253,122,234,95,128,219,117,208,70,89,130,235,99,126,2,164,211,224,8,147,200,251,122,194,177,202,184,145,202,250,118,233,122,141,117,246,157,96,136,83,150,197,198,199,227,183,17,153,138,20,145,130,84,56,237,53,107,81,106,118,250,237,194,112,153,242,28,229,218,157,7,135,96,207,93,163,17,222,3,221,121,158,95,248,28,23,172,180,214,46,91,178,7,163,241,184,37,167,193,139,230,226,36,116,36,216,2,18,98,164,215,212,50,83,28,155,253,177,99,152,122,139,156,238,237,226,172,227,44,237,7,82,125,121,250,16,14,29,132,141,19,58,187,66,31,120,89,11,146,44,142,253,127,0,249,127,0,213,134,225,72,112,115,43,63,227,68,36,81,179,63,20,174,63,83,24,182,93,41,39,5,237,138,8,208,91,212,111,64,68,122,187,81,122,38,77,95,124,205,254,13,171,54,61,111,239,101,25,108,193,42,244,179,171,76,68,45,176,255,125,40,231,215,242,52,87,231,68,245,168,64,57,244,67,234,94,19,234,94,69,69,84,140,173,169,250,99,88,109,49,116,18,253,214,118,85,126,250,34,71,182,174,113,133,182,39,208,181,76,105,104,230,98,180,165,116,199,17,121,178,211,71,217,170,10,52,3,115,112,214,181,165,220,44,80,108,74,137,8,29,220,112,238,54,65,175,95,164,227,206,133,46,80,254,93,206,108,78,107,41,237,157,205,174,38,60,138,217,12,238,231,130,207,129,40,18,156,6,132,246,3,57,79,75,232,162,16,223,104,152,89,146,232,180,38,210,212,100,250,205,78,70,27,114,49,114,155,15,239,46,62,116,143,127,233,190,63,186,188,248,240,241,232,253,232,114,120,116,113,252,110,112,244,177,123,209,61,127,59,56,239,118,143,135,143,77,55,37,243,202,158,72,25,175,77,39,120,128,25,154,83,208,246,111,91,107,201,103,163,101,199,222,43,86,39,137,5,8,139,236,240,59,242,108,27,111,62,26,65,170,133,85,34,107,45,176,95,225,45,85,254,207,59,136,33,96,230,50,218,135,149,129,66,71,4,131,4,239,201,121,104,97,142,23,97,197,60,150,137,107,105,102,142,197,37,41,215,219,214,34,21,154,76,37,186,63,176,6,162,149,233,96,106,255,14,153,27,42,129,84,84,182,156,252,69,181,14,206,71,49,111,253,6,151,80,125,215,178,227,228,112,247,148,221,9,143,76,151,255,4,157,255,94,159,175,146,38,83,241,175,147,70,208,29,236,51,26,224,25,83,225,153,21,176,117,110,236,93,29,225,19,129,67,248,106,25,197,242,62,159,129,207,45,134,76,163,162,198,156,248,175,177,218,91,197,215,170,218,83,87,137,156,130,26,11,155,177,238,102,238,137,252,60,6,155,11,7,213,8,161,154,87,78,212,29,83,161,49,50,250,214,201,109,246,106,152,43,251,245,251,27,35,247,77,246,25,185,84,209,56,162,157,94,48,206,47,20,27,67,191,42,8,90,107,177,246,214,162,13,90,35,17,211,119,171,245,225,30,130,244,55,166,139,133,226,217,45,61,250,187,196,56,17,70,176,88,252,40,62,181,158,64,107,3,4,95,125,121,37,111,44,111,185,108,120,105,85,232,100,244,251,27,171,68,107,107,44,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d93ec393-d854-4c31-8744-226d42cd33ec"));
		}

		#endregion

	}

	#endregion

}

