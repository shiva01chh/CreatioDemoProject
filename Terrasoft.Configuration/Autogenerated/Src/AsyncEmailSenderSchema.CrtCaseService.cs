﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AsyncEmailSenderSchema

	/// <exclude/>
	public class AsyncEmailSenderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AsyncEmailSenderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AsyncEmailSenderSchema(AsyncEmailSenderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6b9100d0-f647-4a24-b9f0-028ee07c0184");
			Name = "AsyncEmailSender";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,193,142,218,48,16,61,103,165,253,135,81,122,1,9,37,247,45,32,33,186,66,84,234,106,37,182,234,177,50,102,0,111,19,59,26,219,108,41,218,127,239,216,33,16,178,165,34,135,68,30,191,55,243,230,101,108,45,74,180,149,144,8,47,72,36,172,89,187,108,106,244,90,109,60,9,167,140,190,191,59,220,223,37,222,42,189,129,197,222,58,44,63,119,214,140,47,10,148,1,108,179,25,106,36,37,207,152,118,90,194,107,241,203,154,87,81,11,185,197,149,47,144,24,193,152,79,132,27,134,195,180,16,214,194,3,76,236,94,203,199,82,168,98,129,122,133,20,65,121,158,195,208,250,178,20,180,31,31,215,19,144,145,178,54,4,34,144,182,100,180,241,22,48,144,193,50,155,171,103,13,59,111,209,43,191,44,148,60,242,63,22,76,14,177,232,73,218,51,153,10,201,41,180,15,240,28,169,245,126,87,85,12,124,183,72,32,141,214,181,155,217,9,216,22,208,40,8,224,233,9,219,93,134,159,150,36,27,116,193,203,228,253,40,138,69,214,186,46,69,50,207,58,47,157,161,91,84,206,181,114,74,20,234,15,90,16,160,241,13,20,211,133,230,25,50,107,112,91,100,10,34,72,194,245,40,237,58,148,230,227,218,187,43,205,197,72,37,72,148,160,121,52,71,169,191,232,43,29,191,112,126,223,241,105,152,71,70,219,157,110,221,94,199,159,203,180,253,163,95,29,208,168,3,187,197,203,111,232,182,102,117,139,143,205,48,91,80,101,137,43,37,28,194,171,89,198,161,60,78,96,61,143,183,90,37,88,228,78,185,253,124,149,142,255,97,201,78,145,243,162,128,157,81,43,8,174,68,143,122,51,207,203,51,181,177,130,207,118,112,99,174,215,6,164,39,66,237,226,120,142,58,147,150,77,207,155,209,159,196,58,10,210,185,149,25,25,95,49,163,142,132,51,46,133,235,125,156,137,1,164,63,249,21,148,100,79,248,22,190,189,126,191,206,182,19,4,177,21,116,72,150,147,133,129,251,162,98,109,118,98,88,231,30,128,89,190,178,160,241,81,125,114,104,187,49,104,245,247,30,247,223,235,228,147,170,58,93,41,167,203,101,222,252,141,175,102,57,236,106,125,252,141,210,243,65,25,247,154,254,6,93,67,126,24,250,21,175,212,236,137,85,15,106,61,45,11,235,112,171,169,254,127,230,170,142,94,6,57,198,207,95,25,209,233,68,186,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6b9100d0-f647-4a24-b9f0-028ee07c0184"));
		}

		#endregion

	}

	#endregion

}

