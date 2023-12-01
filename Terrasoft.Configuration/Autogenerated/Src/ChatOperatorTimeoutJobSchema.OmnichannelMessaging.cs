﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChatOperatorTimeoutJobSchema

	/// <exclude/>
	public class ChatOperatorTimeoutJobSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChatOperatorTimeoutJobSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChatOperatorTimeoutJobSchema(ChatOperatorTimeoutJobSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0f8096c0-592d-b90e-2de3-b4afbfbd03c3");
			Name = "ChatOperatorTimeoutJob";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,84,77,111,218,64,16,61,19,41,255,97,228,94,108,9,25,245,154,0,82,75,72,228,42,41,105,160,205,161,234,97,177,7,216,202,222,37,251,65,139,34,254,123,103,189,54,216,4,154,92,194,206,204,206,188,55,239,173,5,43,80,175,89,138,48,67,165,152,150,11,19,143,164,88,240,165,85,204,112,41,226,73,33,120,186,98,66,96,30,63,160,214,108,201,197,242,242,226,245,242,162,99,53,253,132,233,86,27,44,174,143,206,212,37,207,49,117,45,116,124,135,2,21,79,223,212,220,115,241,114,8,54,17,20,133,20,167,51,10,207,197,227,155,207,148,162,228,7,133,75,154,11,163,156,105,125,5,163,21,51,147,53,18,31,169,102,188,64,105,205,23,57,135,178,180,215,235,65,95,219,162,96,106,59,172,206,211,63,220,164,43,32,210,6,100,117,79,131,54,204,32,24,9,92,48,162,181,193,184,42,31,49,34,154,1,91,24,84,254,18,75,83,92,27,48,126,86,93,215,239,53,230,172,237,60,231,41,164,14,225,57,128,87,144,208,191,241,95,76,45,37,232,210,107,9,121,79,239,1,205,74,102,68,240,81,241,13,129,243,217,181,63,192,92,202,28,18,253,204,184,161,85,221,74,245,68,66,147,24,232,166,77,137,140,213,225,119,141,138,212,22,94,39,176,173,99,23,238,44,207,74,70,73,22,129,19,188,211,217,48,85,110,194,234,41,58,121,97,0,161,192,63,224,79,97,187,67,20,207,228,58,252,24,149,55,59,206,17,182,16,97,224,135,39,89,80,39,110,149,44,194,192,25,205,97,219,135,159,87,168,48,12,92,97,156,232,241,139,101,121,232,123,196,143,76,145,113,105,225,97,5,47,2,166,43,16,209,117,121,191,137,50,246,75,196,41,109,34,199,39,76,165,202,66,133,44,35,197,6,67,240,191,200,165,198,183,255,193,114,139,125,199,126,216,68,219,5,18,230,176,20,159,168,166,41,52,86,137,70,28,6,3,104,60,157,253,203,161,237,104,163,227,131,44,143,74,166,148,164,67,217,105,87,105,140,34,243,50,159,211,188,52,144,79,150,238,226,130,214,197,77,38,201,85,10,23,131,160,105,158,122,1,71,138,119,33,185,225,229,47,178,229,171,54,138,80,16,203,249,111,74,239,162,160,55,44,13,229,173,186,145,196,251,116,155,55,198,105,116,237,183,187,14,97,93,75,167,155,158,242,50,58,55,249,250,232,80,246,51,24,149,201,224,151,95,53,95,64,248,142,175,79,25,217,121,70,227,222,47,245,240,114,122,253,202,147,76,59,8,201,88,216,130,34,243,188,114,65,11,205,228,80,92,67,106,53,121,96,130,45,157,177,192,61,140,73,59,122,252,66,170,251,13,0,49,81,26,179,116,21,30,98,206,163,21,218,206,209,148,152,88,139,37,214,83,28,127,108,220,236,254,207,131,173,75,113,82,127,214,70,50,195,26,215,46,58,65,240,171,52,124,193,247,12,155,95,175,58,245,14,205,186,44,254,84,126,41,93,135,50,180,13,155,139,152,201,123,174,77,24,157,212,175,129,235,197,162,69,111,30,87,216,18,235,155,207,237,133,58,94,223,76,109,159,240,134,59,211,205,201,216,53,15,135,168,26,213,173,251,87,35,119,231,95,169,143,182,131,20,163,191,127,70,147,45,141,103,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0f8096c0-592d-b90e-2de3-b4afbfbd03c3"));
		}

		#endregion

	}

	#endregion

}

