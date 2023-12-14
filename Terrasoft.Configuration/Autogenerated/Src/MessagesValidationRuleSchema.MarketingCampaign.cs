﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MessagesValidationRuleSchema

	/// <exclude/>
	public class MessagesValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MessagesValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MessagesValidationRuleSchema(MessagesValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a157de99-1639-47cc-833c-4ae34f5e8ef8");
			Name = "MessagesValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,85,219,78,219,64,16,125,54,18,255,48,77,95,108,169,114,222,9,137,4,109,160,145,160,66,4,218,71,180,177,199,97,133,189,27,246,146,54,66,252,123,103,189,235,196,118,18,218,40,146,61,187,115,57,51,115,102,44,88,133,122,197,50,132,7,84,138,105,89,152,244,171,20,5,95,90,197,12,151,226,244,228,237,244,36,178,154,139,37,204,55,218,96,53,234,201,164,95,150,152,57,101,157,94,163,64,197,179,61,157,27,46,94,119,135,237,88,85,37,197,225,27,133,199,206,211,111,151,116,69,151,195,225,16,206,181,173,42,166,54,147,32,255,100,37,207,107,236,160,108,137,80,72,5,11,91,190,0,86,140,151,80,49,173,217,18,117,218,152,15,91,246,43,187,40,121,6,89,73,74,112,139,94,115,231,240,222,249,59,131,217,124,133,25,47,120,214,189,57,191,182,60,119,94,222,106,108,209,103,133,75,135,226,138,99,153,235,51,184,83,124,205,12,250,203,149,23,64,33,203,165,40,55,112,75,224,40,211,57,170,53,167,118,60,85,29,121,116,208,230,81,163,162,110,9,95,125,120,178,29,121,20,96,160,200,61,146,46,44,82,212,70,217,204,72,229,192,213,153,7,108,190,10,135,243,143,123,64,187,56,191,244,49,117,33,37,224,216,20,69,189,236,96,12,7,210,141,122,249,144,214,94,130,81,244,254,113,150,119,74,174,80,25,142,135,115,164,10,56,122,77,149,34,150,188,193,18,205,8,154,50,107,39,252,195,253,45,154,103,121,180,185,179,169,176,21,42,182,104,200,1,215,104,46,137,139,83,151,238,44,71,97,136,70,168,116,236,110,65,175,74,110,30,80,155,89,222,20,106,205,20,181,91,219,210,236,166,140,234,32,240,55,220,112,109,188,215,56,25,109,149,23,141,247,57,58,245,160,235,133,184,87,208,196,141,174,173,68,60,152,229,131,36,189,82,178,138,5,45,4,89,196,91,144,73,146,254,122,70,133,241,96,190,67,55,72,234,120,81,58,211,211,87,203,202,216,251,73,239,152,34,115,131,42,110,167,146,0,211,1,129,199,217,195,152,250,113,218,252,144,55,50,123,249,206,133,209,77,70,125,205,233,31,204,172,193,123,26,0,10,162,234,7,140,39,161,88,81,191,82,233,69,158,7,45,218,76,198,163,36,58,219,208,14,159,120,136,245,30,158,10,141,85,98,175,234,255,67,182,29,27,90,76,235,239,168,246,146,194,206,102,10,243,182,53,26,246,173,206,87,174,192,224,122,52,30,180,74,60,152,60,10,254,106,17,248,150,82,32,11,207,39,48,164,2,70,194,58,132,60,31,214,94,38,173,41,88,72,89,110,33,29,229,226,62,155,119,225,52,17,237,24,183,219,174,124,137,59,95,152,48,242,247,244,29,162,141,228,182,91,120,25,247,151,96,218,64,108,54,83,220,2,144,62,200,11,250,70,108,226,166,159,188,136,63,53,190,210,185,205,50,50,106,82,137,252,192,143,183,193,210,250,96,38,10,153,6,231,163,134,82,53,27,10,86,234,112,244,222,102,9,45,80,252,128,25,116,74,127,247,251,11,0,232,120,88,105,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a157de99-1639-47cc-833c-4ae34f5e8ef8"));
		}

		#endregion

	}

	#endregion

}

