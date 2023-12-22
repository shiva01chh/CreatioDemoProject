﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventConditionalTransitionFlowElementSchema

	/// <exclude/>
	public class EventConditionalTransitionFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventConditionalTransitionFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventConditionalTransitionFlowElementSchema(EventConditionalTransitionFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c6c9eea4-a71d-4b2e-b4f1-18cdef716973");
			Name = "EventConditionalTransitionFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,85,75,79,227,48,16,190,35,241,31,134,114,73,47,233,157,182,72,208,45,44,18,139,88,30,226,108,146,73,107,145,216,169,31,101,171,194,127,223,177,221,54,143,166,162,62,68,201,120,252,205,55,223,140,39,130,21,168,75,150,32,188,160,82,76,203,204,196,19,41,50,62,179,138,25,46,197,233,201,250,244,4,104,89,205,197,12,158,87,218,96,49,220,55,209,169,60,199,196,29,209,241,45,10,84,60,233,114,187,231,98,209,176,215,227,22,133,20,7,55,21,198,191,174,105,55,236,159,43,156,81,44,152,228,76,235,11,152,46,81,24,34,158,114,199,128,229,47,138,9,237,223,111,114,249,57,205,177,160,253,237,217,193,96,0,35,109,139,130,169,213,101,101,242,24,144,84,32,96,118,40,80,42,153,160,214,128,1,42,174,33,13,154,80,165,125,207,121,2,137,35,118,28,47,184,128,159,169,59,232,245,54,131,186,2,143,74,150,168,12,71,146,225,209,199,174,123,117,228,186,53,191,10,190,176,8,60,37,124,158,113,84,32,51,192,101,149,221,161,12,107,89,222,90,158,134,36,239,82,88,195,12,205,16,180,123,124,31,73,162,106,27,23,93,163,251,192,52,208,0,69,189,73,253,228,56,234,227,57,221,77,133,45,80,177,247,28,71,142,223,101,32,248,180,1,211,135,121,158,163,72,131,170,93,66,255,65,51,151,169,83,89,241,37,51,88,247,41,131,9,150,210,233,241,207,16,208,27,55,243,93,204,168,15,235,202,219,173,170,204,127,45,170,85,60,153,99,242,113,165,102,214,149,251,193,230,121,212,107,185,244,250,195,38,132,183,238,68,122,246,218,193,24,110,209,132,247,235,213,35,163,198,72,120,201,106,233,71,109,24,158,65,212,2,57,27,131,32,10,123,164,187,136,95,137,52,234,81,255,26,150,80,19,244,250,241,157,104,193,181,3,126,87,159,223,93,34,134,188,126,76,163,77,206,229,177,109,197,241,24,82,204,152,205,77,228,90,160,15,95,95,112,214,108,3,34,190,138,250,157,41,42,52,86,9,47,193,97,234,110,45,153,218,215,95,224,39,132,143,232,85,163,34,105,68,232,240,254,126,36,55,54,109,33,26,2,118,120,221,40,89,68,61,207,255,133,41,234,222,78,175,183,57,42,220,184,133,74,232,233,194,178,60,10,65,98,146,145,198,189,65,181,149,169,223,129,226,145,124,77,27,114,109,43,219,134,210,81,83,85,18,148,233,77,250,45,237,154,66,197,207,37,38,60,91,61,200,123,153,124,252,230,194,232,200,40,139,237,102,217,212,162,121,120,120,160,131,142,190,192,210,248,57,115,228,144,122,242,28,52,44,124,99,154,57,51,192,69,146,219,148,134,9,75,119,191,139,92,206,120,114,196,156,242,246,144,151,190,188,102,52,223,70,26,17,18,133,217,184,247,90,166,116,7,122,131,75,64,63,70,104,24,126,210,36,1,195,11,4,38,82,200,120,78,186,87,255,41,29,143,6,91,176,250,93,218,164,8,114,73,63,81,26,242,97,54,77,20,18,188,191,97,251,55,232,157,184,196,13,143,86,49,58,39,219,241,197,216,109,55,183,188,185,190,254,3,73,141,41,107,150,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c6c9eea4-a71d-4b2e-b4f1-18cdef716973"));
		}

		#endregion

	}

	#endregion

}

