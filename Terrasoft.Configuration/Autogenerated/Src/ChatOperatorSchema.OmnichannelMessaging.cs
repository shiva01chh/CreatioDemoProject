﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChatOperatorSchema

	/// <exclude/>
	public class ChatOperatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChatOperatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChatOperatorSchema(ChatOperatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d4824517-fb06-74c8-eeb3-f54e87ff3606");
			Name = "ChatOperator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,85,77,111,218,64,16,61,19,41,255,97,148,94,64,170,76,207,37,32,33,163,70,72,137,146,10,146,75,213,195,98,15,102,165,101,77,247,131,136,162,252,247,206,238,218,128,13,114,93,202,193,50,235,55,111,222,206,167,100,107,212,27,150,32,204,81,41,166,243,165,137,226,92,46,121,102,21,51,60,151,209,243,90,242,100,197,164,68,17,61,161,214,44,227,50,131,219,155,253,237,77,199,106,247,62,219,105,131,235,65,237,63,209,8,129,137,227,208,209,3,74,84,60,33,12,161,62,41,204,232,20,98,193,180,254,10,241,138,153,231,13,146,187,92,249,239,63,102,132,101,130,255,102,11,129,63,233,96,99,23,130,39,144,56,124,13,222,217,123,147,3,231,55,142,34,37,210,23,111,18,190,245,251,125,184,215,118,189,102,106,55,42,15,130,72,176,26,21,240,20,165,225,75,142,42,58,224,251,167,6,133,0,133,44,205,165,216,193,131,229,41,188,146,233,52,29,20,254,81,166,65,66,85,15,197,82,27,101,19,18,91,83,85,112,158,94,167,235,121,173,231,237,129,11,112,167,19,188,192,176,56,118,81,238,124,52,251,124,81,57,17,26,142,109,226,80,250,6,109,152,193,227,253,53,34,19,58,135,68,225,114,120,87,162,102,14,116,215,31,53,134,169,2,134,240,220,67,134,102,0,218,61,62,232,54,18,223,107,184,61,248,251,250,187,158,212,220,161,228,124,36,117,84,49,138,166,146,81,133,109,233,37,253,236,205,227,60,197,171,8,156,97,160,40,1,227,45,227,194,149,224,85,124,103,44,62,113,131,134,76,76,53,228,101,50,2,9,44,5,203,154,75,114,145,231,2,198,1,61,28,133,96,159,251,110,114,123,40,128,196,42,69,125,64,190,19,220,24,76,129,46,108,52,36,185,149,166,89,4,39,171,160,193,85,179,142,157,197,89,198,191,180,18,145,114,69,51,227,224,252,216,153,186,89,194,35,215,230,222,181,207,8,38,5,133,215,114,177,240,142,224,110,239,159,66,83,83,215,50,52,21,65,69,112,124,165,145,178,226,173,163,208,88,37,171,208,200,99,125,199,187,150,63,244,253,69,173,143,76,27,48,124,141,240,190,66,121,90,73,39,217,132,46,151,240,58,143,123,141,154,39,84,67,115,199,228,56,157,146,113,193,49,185,212,201,37,58,122,226,242,141,9,219,174,216,138,2,47,122,10,126,89,180,120,93,186,157,192,239,193,188,101,174,107,115,51,68,181,118,88,219,81,149,38,111,177,164,106,163,237,63,230,115,96,104,187,161,252,2,161,17,90,137,196,95,217,19,154,125,205,188,180,195,220,102,247,211,181,45,119,101,158,109,41,84,126,150,82,1,154,21,215,97,221,180,29,112,231,35,249,130,136,22,105,165,51,250,253,1,55,220,152,171,244,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d4824517-fb06-74c8-eeb3-f54e87ff3606"));
		}

		#endregion

	}

	#endregion

}

