﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OrderInvoiceHelperSchema

	/// <exclude/>
	public class OrderInvoiceHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OrderInvoiceHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OrderInvoiceHelperSchema(OrderInvoiceHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4ad2243e-f8fe-48a3-a75c-73dc11188592");
			Name = "OrderInvoiceHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("650a2ad9-42d3-4738-b18c-b0f4ce2ed031");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,87,75,111,219,56,16,62,203,128,255,3,155,0,133,12,8,242,125,99,7,216,38,77,214,104,179,27,172,187,189,51,210,216,97,33,81,94,62,92,24,69,254,123,73,145,178,249,144,21,5,232,161,62,88,34,57,243,205,55,15,146,35,201,9,221,162,245,129,11,168,175,166,19,233,12,243,155,166,170,160,16,164,161,60,191,7,10,140,20,161,200,103,66,255,63,206,125,1,198,48,111,54,66,105,50,56,51,157,127,164,130,8,2,252,184,174,103,111,26,186,33,91,201,176,182,134,150,161,142,183,172,20,167,19,138,107,224,59,92,128,39,234,72,229,255,176,18,216,138,238,27,82,192,116,242,99,58,73,118,242,169,34,5,42,42,204,57,114,151,255,130,106,7,76,73,252,208,208,73,114,201,96,171,121,40,64,46,152,44,68,195,248,31,232,177,85,55,18,22,42,6,73,255,227,192,148,30,53,129,67,210,27,206,144,230,145,36,129,208,50,16,187,210,66,47,150,11,208,210,208,241,185,61,178,70,153,211,129,236,101,22,88,8,134,134,197,22,68,107,41,217,49,178,199,2,16,183,19,47,250,111,200,248,3,136,231,166,212,150,89,35,20,38,148,214,120,55,68,123,194,132,196,21,106,179,125,64,247,32,214,141,100,5,152,113,106,30,235,226,25,106,140,120,187,98,6,25,186,37,45,71,204,14,11,21,124,85,32,25,50,207,107,180,199,21,41,85,85,202,154,214,120,151,161,123,73,74,171,253,111,243,125,85,118,225,221,99,134,192,24,94,122,232,249,13,3,229,168,37,225,7,101,102,98,177,250,72,101,13,12,63,85,176,232,236,22,173,73,254,165,185,3,81,60,43,76,159,72,254,21,87,18,120,126,75,184,32,180,16,169,133,50,20,242,86,233,142,53,245,237,135,212,35,163,130,242,200,72,173,60,53,80,127,171,154,78,103,153,235,81,22,216,182,200,12,132,100,212,250,232,86,203,80,2,110,65,211,107,55,71,95,22,202,211,178,153,233,141,102,36,53,34,164,54,14,107,77,97,99,92,53,17,75,199,187,51,80,21,202,181,175,167,124,60,224,221,80,117,13,187,60,88,125,132,238,164,80,240,110,92,24,112,89,9,21,23,10,223,7,116,59,71,55,234,48,195,170,130,82,173,91,116,124,87,234,36,85,232,145,129,132,108,80,218,19,112,83,17,249,29,161,229,135,67,91,52,30,84,254,9,14,51,244,78,113,146,85,133,222,191,71,6,44,73,252,157,240,26,74,155,162,35,206,145,83,155,46,237,116,254,103,89,198,134,51,212,135,98,188,55,231,138,253,183,57,55,88,103,74,184,81,219,251,142,84,149,87,51,182,160,141,51,93,66,221,84,14,38,241,200,174,115,104,56,37,145,120,226,22,144,225,229,218,182,51,222,62,201,131,136,171,122,61,155,182,171,179,70,140,191,71,124,51,28,11,237,101,161,121,250,166,226,171,207,48,9,39,36,165,234,132,57,117,205,117,138,158,79,190,120,20,130,204,224,91,213,151,183,231,247,181,132,26,47,126,139,132,14,110,196,171,222,173,108,97,163,205,245,182,16,143,219,106,175,52,18,167,187,220,233,34,230,243,57,90,112,89,235,203,233,186,155,184,52,63,212,61,156,137,238,213,89,117,31,151,89,160,124,122,201,143,230,230,161,189,197,14,51,92,35,221,234,45,47,220,195,75,135,250,226,58,68,58,65,46,230,173,102,63,80,116,160,246,163,141,3,115,174,234,139,235,85,217,121,253,70,74,199,60,158,104,244,81,185,68,105,247,54,115,162,159,218,137,241,150,218,74,137,204,245,68,18,245,14,123,108,152,211,156,159,66,48,164,219,9,59,237,106,215,173,180,29,157,215,81,152,253,142,194,244,119,39,122,124,135,155,213,176,53,204,236,45,56,230,106,24,113,222,116,17,68,254,6,238,105,60,188,169,101,208,136,231,238,234,3,166,120,11,76,159,196,43,245,221,129,105,1,246,84,9,157,183,155,252,92,47,243,43,76,246,134,213,218,29,215,161,155,232,196,205,89,28,150,236,28,121,231,132,243,92,246,66,107,140,120,95,23,125,38,124,102,94,147,237,99,71,92,140,129,184,123,62,67,218,162,69,247,154,75,170,199,227,144,161,133,209,247,70,80,114,225,165,17,89,234,193,246,33,220,91,57,137,164,243,53,222,67,186,193,21,7,191,63,143,37,189,207,151,22,253,220,167,171,158,107,167,167,19,245,251,9,190,170,212,177,118,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4ad2243e-f8fe-48a3-a75c-73dc11188592"));
		}

		#endregion

	}

	#endregion

}

