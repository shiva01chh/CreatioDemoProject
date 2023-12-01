﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ConditionalTransitionFlowElementSchema

	/// <exclude/>
	public class ConditionalTransitionFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ConditionalTransitionFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ConditionalTransitionFlowElementSchema(ConditionalTransitionFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7834dd6b-aacf-4fd5-8228-946288744800");
			Name = "ConditionalTransitionFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,88,91,83,219,56,20,126,78,103,250,31,68,246,197,217,1,211,150,182,195,110,26,58,64,146,66,167,5,218,192,242,176,179,179,163,216,199,68,173,99,165,146,12,100,90,254,251,30,93,226,200,142,19,146,238,46,15,76,44,233,156,243,157,239,92,116,201,232,24,228,132,70,64,46,65,8,42,121,162,194,99,158,37,236,38,23,84,49,158,61,125,242,253,233,147,70,46,89,118,67,6,83,169,96,220,174,124,135,151,112,175,230,131,190,158,241,152,103,245,51,2,194,238,17,78,225,228,47,2,110,208,16,57,78,169,148,191,19,180,30,51,109,153,166,151,130,102,210,252,238,167,252,174,151,194,24,50,101,100,118,119,119,201,27,153,143,199,84,76,15,220,183,39,72,84,33,73,38,130,71,32,37,1,43,30,206,164,119,61,241,73,62,76,89,68,34,141,224,81,0,4,49,210,241,132,178,155,108,62,127,97,173,20,24,27,223,13,206,194,185,62,131,52,70,239,46,4,187,165,10,236,228,196,126,16,1,52,230,89,58,37,82,9,77,20,34,80,52,82,131,104,4,99,122,134,17,34,29,210,116,131,205,118,173,228,187,156,197,101,185,171,211,24,197,50,184,51,115,65,243,249,235,163,222,222,235,87,207,119,246,251,189,23,59,47,159,191,250,109,103,191,219,125,182,115,184,255,108,175,251,242,245,254,94,183,187,215,108,181,29,108,200,98,139,188,236,6,186,57,1,161,24,24,87,184,130,72,65,92,118,166,207,211,24,196,9,164,184,144,252,157,120,95,78,119,53,118,102,224,48,35,44,147,138,102,152,137,60,33,106,4,184,6,128,68,2,146,78,211,215,217,220,61,8,11,53,126,16,17,129,3,84,198,80,250,208,201,220,104,220,128,34,157,131,50,58,242,246,45,9,202,35,150,62,95,62,104,181,12,255,13,89,167,161,67,110,105,154,131,89,241,176,1,145,38,251,86,144,211,133,132,101,32,9,75,252,196,134,123,136,114,243,139,73,18,67,74,167,16,47,99,198,230,247,144,243,148,156,202,174,93,59,80,84,40,242,157,32,25,109,34,245,191,135,149,24,80,8,99,68,98,58,149,100,8,9,150,176,9,83,228,149,93,130,85,50,199,181,26,12,195,74,50,74,79,179,174,86,185,25,144,60,99,138,32,6,50,209,78,96,198,124,203,65,76,201,29,83,35,162,216,216,131,181,26,133,87,236,3,64,29,152,127,186,212,141,145,43,109,99,254,107,125,128,171,163,53,162,146,80,146,176,84,129,88,35,94,39,84,246,205,218,181,1,32,90,244,132,176,24,59,17,75,24,74,186,138,18,16,113,17,235,32,186,78,97,83,155,40,58,76,97,53,20,211,95,44,14,236,43,235,34,25,0,21,209,8,83,70,81,162,184,243,153,68,174,123,154,216,177,136,77,104,166,228,106,243,174,49,110,72,68,15,253,87,216,85,77,63,244,249,248,87,88,60,42,172,129,121,191,253,57,96,153,238,240,119,35,134,76,21,112,104,30,51,157,140,152,209,105,138,229,230,240,98,111,27,78,55,160,202,7,104,54,146,117,17,30,243,52,31,107,86,176,158,116,153,233,244,41,32,128,209,186,49,12,151,116,23,90,103,13,142,101,173,242,35,168,17,95,186,119,234,54,242,14,148,235,36,39,60,23,50,104,185,54,47,64,229,34,243,74,184,211,121,180,224,67,211,140,222,150,90,211,175,228,197,75,220,245,189,33,191,197,207,144,220,114,204,139,222,189,66,55,174,177,13,93,98,23,42,140,21,144,176,41,4,91,149,22,252,227,71,201,26,130,124,166,199,116,212,226,60,133,184,171,181,227,104,150,167,233,76,143,243,205,110,70,15,230,255,45,21,228,11,31,22,98,231,25,110,72,129,22,214,80,90,37,117,237,66,194,109,28,134,56,92,191,64,165,93,57,211,162,75,25,180,119,60,183,235,80,164,108,51,60,140,173,178,96,199,87,237,244,204,15,76,159,116,191,14,15,51,60,153,12,20,76,240,172,56,73,65,105,13,205,86,120,42,63,224,97,234,92,244,190,229,52,13,108,46,134,23,84,96,6,99,54,5,85,16,110,83,174,196,99,128,39,190,200,36,135,77,66,251,29,12,167,10,254,252,11,51,79,183,38,244,139,206,40,213,108,128,252,134,30,249,59,126,168,25,153,98,137,178,200,14,247,6,159,130,250,226,218,246,148,110,147,43,9,2,227,159,161,77,116,215,249,175,195,111,108,212,70,211,140,249,33,197,165,33,234,57,140,199,44,251,204,110,70,74,135,40,161,169,116,1,116,98,122,25,194,180,14,26,98,131,58,235,171,243,245,3,203,190,66,108,125,178,254,5,142,193,196,163,111,134,216,31,51,81,92,70,73,243,52,54,1,117,161,116,253,237,98,222,109,79,179,132,95,234,13,8,215,250,24,180,220,60,77,39,101,1,135,204,30,208,92,96,43,46,91,98,67,155,60,155,26,118,194,125,193,199,43,69,103,11,79,209,172,120,207,89,22,232,102,206,147,0,175,70,150,133,150,91,210,8,207,107,38,209,244,213,38,4,89,132,231,195,47,232,228,28,103,195,68,160,78,185,142,129,175,189,90,73,245,81,107,45,186,181,100,161,231,219,122,9,176,140,233,235,17,238,44,143,121,95,55,253,8,121,51,209,42,89,173,176,119,207,164,146,65,57,185,241,104,102,127,218,204,171,205,186,112,48,129,136,37,211,51,254,129,71,95,79,112,3,42,218,100,93,123,43,44,213,42,91,167,50,43,123,104,101,71,209,213,49,239,59,88,18,189,44,226,49,238,189,225,213,101,127,95,247,133,35,236,120,210,197,199,235,67,91,165,54,119,60,130,232,235,160,208,83,156,58,127,166,215,61,178,73,249,148,219,45,167,212,160,189,206,60,7,91,234,55,8,174,224,161,176,101,218,183,102,26,93,47,102,77,191,244,69,139,153,240,56,229,25,124,4,140,207,181,160,147,163,20,99,57,11,99,99,169,8,66,171,95,100,243,119,209,126,203,119,94,59,178,228,92,182,213,33,174,126,221,41,105,78,226,202,22,93,74,223,246,50,214,215,99,240,191,235,233,69,193,90,95,230,173,252,129,0,110,94,181,6,45,131,255,131,201,199,43,115,145,196,117,10,178,32,80,239,18,182,150,74,199,188,217,109,73,163,30,79,212,52,88,85,23,179,173,214,168,41,74,163,122,16,233,123,211,127,188,8,22,222,137,230,254,219,149,205,237,226,206,182,109,45,47,61,149,148,44,111,85,142,39,181,199,54,143,105,220,40,74,10,124,234,55,162,178,124,78,46,154,208,10,226,234,107,234,170,150,246,101,151,145,142,73,175,246,226,162,210,11,220,2,219,75,5,236,211,91,245,53,174,30,53,194,60,227,234,12,217,62,23,215,35,166,96,160,95,99,131,186,242,95,178,15,44,173,250,181,18,118,157,199,42,239,6,86,122,242,171,189,57,126,54,56,164,123,144,81,35,170,240,142,22,165,121,12,146,208,184,120,42,74,249,13,139,150,92,33,205,136,245,71,30,28,81,89,122,11,188,154,232,227,127,115,247,0,187,189,246,15,239,163,243,87,31,154,197,197,205,190,232,193,225,155,221,153,50,155,137,179,103,66,126,11,66,176,216,37,229,177,0,84,108,143,207,51,246,135,104,60,44,77,180,43,212,86,174,121,213,233,133,252,94,193,183,29,45,15,154,49,252,251,7,206,156,42,194,168,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7834dd6b-aacf-4fd5-8228-946288744800"));
		}

		#endregion

	}

	#endregion

}

