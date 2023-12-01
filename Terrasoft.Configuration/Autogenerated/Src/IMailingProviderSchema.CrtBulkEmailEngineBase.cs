﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingProviderSchema

	/// <exclude/>
	public class IMailingProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingProviderSchema(IMailingProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e61e4aec-17df-4c2f-abaa-d1b6b043b462");
			Name = "IMailingProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6e206974-7c3f-4704-9c49-6b38b2d992b2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,86,77,79,219,64,16,61,7,137,255,48,74,15,165,18,74,238,124,228,208,128,170,28,162,70,24,122,65,61,108,236,177,179,197,222,117,247,131,54,66,253,239,157,93,127,196,9,177,49,84,45,148,11,241,120,246,237,155,183,179,227,39,88,134,58,103,33,194,53,42,197,180,140,205,104,42,69,204,19,171,152,225,82,28,30,60,28,30,12,172,230,34,129,96,173,13,102,167,245,243,84,42,220,60,181,0,140,166,151,1,37,81,218,59,133,9,5,96,38,12,170,152,246,60,129,217,156,241,148,22,47,148,188,231,17,42,159,55,30,143,225,76,219,44,99,106,61,41,159,203,4,13,25,154,149,140,52,48,17,65,174,100,142,202,112,10,203,24,204,10,33,43,224,220,27,143,55,170,224,198,13,188,220,46,83,30,2,175,104,236,97,49,120,240,76,106,202,139,122,167,19,88,248,229,197,251,93,170,62,48,19,218,48,65,184,68,42,180,74,161,48,96,53,42,8,165,16,24,122,81,234,197,77,98,131,27,202,154,214,73,176,243,232,14,98,48,72,208,156,250,31,186,252,241,171,164,138,34,42,216,110,83,159,23,130,245,224,253,81,33,187,211,78,187,16,181,151,84,19,38,233,210,194,214,71,114,166,88,6,130,218,232,124,184,180,233,221,165,59,130,89,52,156,220,8,254,221,34,144,158,194,240,152,83,249,229,25,185,44,64,151,54,58,27,251,229,27,52,133,198,42,161,39,87,197,127,32,33,141,245,84,182,86,85,105,110,93,121,118,87,212,198,82,104,44,170,40,131,71,159,44,143,160,65,235,195,105,71,253,129,97,202,232,170,232,61,116,255,153,12,77,52,174,47,48,101,107,140,60,189,225,228,2,221,99,125,52,127,67,194,128,176,231,212,2,44,193,71,10,30,195,82,202,20,182,89,193,57,196,44,213,120,76,187,41,167,29,203,115,234,53,127,255,111,84,74,175,135,195,23,72,159,21,28,250,234,94,166,207,68,44,135,147,207,203,111,116,109,8,134,25,88,201,148,38,6,167,184,202,60,39,96,75,105,77,141,223,170,97,80,107,183,73,237,43,220,108,190,161,3,13,106,221,58,16,128,6,131,218,188,102,203,209,156,50,44,52,157,88,101,14,196,74,102,192,108,196,145,38,94,55,172,223,249,10,67,158,83,50,117,178,39,12,44,162,177,165,235,9,174,170,247,79,119,54,45,179,169,241,115,202,134,110,100,197,54,109,220,139,230,65,249,158,117,226,94,147,180,237,173,237,35,117,245,117,55,111,19,239,60,192,47,44,229,17,51,254,67,245,162,230,237,210,252,201,126,45,119,119,29,94,136,179,35,195,214,135,57,64,117,207,67,172,155,183,162,190,37,79,77,235,121,85,235,103,151,173,247,212,173,95,165,112,237,43,191,253,186,169,93,247,44,126,115,191,104,218,196,100,81,214,174,0,78,158,201,77,31,184,80,44,54,229,60,126,193,197,126,3,10,249,10,138,161,88,137,212,36,216,41,211,162,233,203,222,187,89,239,247,104,17,194,95,216,69,195,147,29,85,224,59,62,167,112,63,205,224,160,197,106,6,36,17,197,48,234,235,57,47,127,154,98,28,175,30,91,68,248,193,205,202,191,145,247,168,82,201,34,140,74,111,218,252,10,244,244,159,109,212,96,159,67,222,245,166,253,13,222,219,52,56,186,40,222,97,205,42,16,13,200,66,210,87,241,36,33,196,202,214,151,169,255,153,97,242,145,186,202,63,48,80,224,246,238,117,7,14,15,124,140,254,126,3,135,151,47,97,225,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e61e4aec-17df-4c2f-abaa-d1b6b043b462"));
		}

		#endregion

	}

	#endregion

}

