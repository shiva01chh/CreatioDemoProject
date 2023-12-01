﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MessageHistoryManagerSchema

	/// <exclude/>
	public class MessageHistoryManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MessageHistoryManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MessageHistoryManagerSchema(MessageHistoryManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("80921df7-0fa7-4cf7-bfa6-9af3e114c5d0");
			Name = "MessageHistoryManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4a46c73e-2533-4fb4-8b08-c16580add3d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,219,110,219,56,16,125,86,129,254,3,215,125,161,128,64,31,208,38,89,196,137,211,122,17,59,233,166,151,199,128,150,198,49,91,137,244,242,146,172,176,200,191,119,72,138,186,89,78,177,1,146,136,228,153,51,51,103,102,72,193,42,208,123,150,3,249,2,74,49,45,183,38,187,148,98,203,31,173,98,134,75,241,246,205,127,111,223,36,86,115,241,72,238,107,109,160,250,48,90,35,190,44,33,119,96,157,125,4,1,138,231,7,152,43,102,88,183,217,247,85,85,82,76,159,40,56,182,159,93,205,143,30,93,179,220,72,197,65,35,2,49,239,20,60,98,100,228,178,100,90,191,39,43,208,154,61,194,39,174,17,84,175,152,192,133,242,192,189,221,148,60,39,185,195,29,131,37,78,139,196,253,70,218,107,14,101,129,188,119,138,63,49,3,158,41,217,135,5,81,192,10,41,202,154,44,27,190,181,52,124,203,65,145,7,209,124,125,152,196,223,160,223,83,109,20,166,119,78,30,74,92,57,89,245,52,248,171,6,133,37,19,161,4,228,193,14,214,65,133,228,29,136,34,132,220,172,163,44,88,52,163,172,147,12,147,240,18,52,57,4,57,38,133,160,35,151,67,143,39,135,233,198,108,83,226,5,76,70,49,146,51,114,16,180,67,69,51,60,31,232,149,116,146,224,209,71,48,55,113,73,83,15,120,121,61,233,21,152,157,60,90,53,185,249,129,81,56,218,37,106,195,68,14,52,148,130,68,175,49,141,39,166,200,179,84,63,253,0,125,169,247,112,167,228,19,47,124,192,190,223,66,47,214,56,21,230,116,249,125,10,121,222,68,156,184,77,98,220,159,179,105,78,71,226,214,180,141,34,24,42,48,86,137,96,250,7,10,101,203,146,252,73,46,80,71,204,70,170,236,18,27,197,64,155,138,195,157,140,155,36,37,239,189,97,95,188,40,199,114,33,108,5,138,109,74,56,141,133,141,122,159,147,192,107,56,34,123,69,232,233,227,162,117,245,131,231,208,213,7,20,81,128,45,14,47,203,119,132,70,43,119,74,184,232,245,127,228,245,196,188,201,8,201,233,152,52,237,23,111,164,87,194,183,132,182,198,141,98,45,115,226,208,217,69,81,180,144,104,246,226,255,189,244,53,119,216,41,201,6,227,59,108,207,158,50,10,180,45,7,218,52,38,81,17,7,210,224,174,214,6,116,239,23,116,92,188,16,159,187,134,109,37,232,108,117,51,59,33,51,223,127,107,188,221,103,241,252,90,201,138,206,98,44,243,58,78,231,44,205,46,52,30,172,91,228,13,108,205,173,53,160,254,146,220,17,14,197,109,240,232,38,205,110,91,127,203,2,151,75,189,248,199,178,210,147,225,222,200,208,65,94,245,48,138,104,181,142,30,214,191,241,16,13,123,30,190,239,64,65,52,189,207,119,80,177,175,3,6,39,232,103,11,170,190,99,10,101,194,88,104,123,225,100,13,239,82,108,101,214,26,167,145,251,66,20,180,249,78,178,219,61,136,121,41,243,159,19,202,163,51,12,45,248,11,229,201,58,111,161,218,217,162,218,155,58,82,59,62,53,69,132,52,212,211,97,179,118,190,47,75,169,33,56,79,9,211,77,131,132,238,9,143,35,189,154,47,254,133,220,226,77,64,138,77,251,121,54,190,1,178,133,208,86,193,213,188,219,162,105,59,21,13,215,210,189,226,127,227,187,131,131,89,116,159,103,77,151,102,129,30,194,54,237,220,117,68,201,243,142,151,64,104,103,157,185,127,61,87,110,184,220,92,248,25,236,193,112,140,130,130,223,88,105,161,29,149,190,72,113,82,155,33,157,154,216,192,253,255,222,136,195,71,241,73,242,130,248,158,171,219,137,62,122,125,77,223,144,109,190,93,207,221,219,141,206,21,223,28,220,88,47,195,215,48,139,158,95,73,35,236,14,55,113,15,127,126,1,252,46,128,190,241,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("80921df7-0fa7-4cf7-bfa6-9af3e114c5d0"));
		}

		#endregion

	}

	#endregion

}

