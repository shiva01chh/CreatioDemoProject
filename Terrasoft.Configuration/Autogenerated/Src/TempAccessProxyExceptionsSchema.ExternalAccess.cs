﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TempAccessProxyExceptionsSchema

	/// <exclude/>
	public class TempAccessProxyExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TempAccessProxyExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TempAccessProxyExceptionsSchema(TempAccessProxyExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f12bace-72ee-4042-9a07-c5a18b5d88ca");
			Name = "TempAccessProxyExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f214e3c2-8cc2-4e62-be3f-96a9b4832c80");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,77,111,218,64,16,61,131,196,127,24,145,11,72,150,125,167,4,9,165,57,228,210,68,34,61,85,61,44,203,216,172,98,239,90,179,187,1,26,245,191,119,188,230,195,128,137,218,164,82,123,200,201,242,120,102,222,188,55,227,167,69,129,182,20,18,225,17,137,132,53,169,139,111,140,78,85,230,73,56,101,116,124,187,118,72,90,228,83,41,209,218,7,33,159,68,134,189,238,75,175,219,241,86,233,12,102,27,235,176,248,212,235,114,228,138,48,227,34,184,201,133,181,35,152,150,106,134,244,140,116,187,150,88,86,237,66,214,183,251,185,53,57,58,28,244,191,218,38,242,253,212,187,229,157,118,152,237,193,183,117,241,121,171,126,4,142,60,14,191,115,199,36,73,96,108,125,81,8,218,76,182,239,143,75,4,220,37,131,91,10,7,202,242,147,204,74,195,106,137,26,74,50,235,13,100,198,1,79,96,8,82,50,5,136,82,129,13,72,241,174,113,210,232,92,250,121,174,36,200,138,96,11,63,24,65,131,107,231,37,240,61,200,98,180,229,153,165,51,196,234,60,132,86,117,198,41,129,16,184,211,202,41,145,171,31,104,65,128,198,21,40,174,23,154,183,101,82,102,130,92,130,8,146,48,189,238,183,8,148,76,234,57,227,61,66,114,10,49,46,5,137,2,52,159,193,117,159,79,193,242,114,251,147,74,186,237,75,45,220,2,173,36,53,71,27,80,131,90,241,56,9,181,161,213,86,149,243,25,6,204,183,58,146,109,183,97,149,220,25,193,92,88,28,236,98,80,221,82,231,231,255,42,68,125,27,71,114,224,186,204,5,143,16,160,9,249,120,53,164,156,228,154,39,119,36,208,25,132,210,186,57,225,228,210,181,50,43,225,237,158,167,244,68,168,221,33,53,2,198,101,77,124,158,243,36,41,242,87,137,59,68,149,130,54,16,160,26,205,185,175,45,81,170,84,225,226,77,91,140,14,55,14,199,60,134,112,188,219,232,236,123,115,215,87,168,23,245,159,17,222,235,232,73,240,146,163,240,175,164,81,58,245,172,220,230,47,186,75,107,219,247,59,77,101,42,82,240,138,82,161,114,92,192,194,243,42,115,85,109,210,169,2,141,119,17,159,181,91,25,122,170,92,105,158,99,97,35,248,252,101,22,10,60,177,144,232,228,31,24,82,43,143,15,115,186,172,205,191,52,170,246,163,251,48,173,55,153,214,239,108,247,21,3,107,217,251,187,77,44,196,186,221,95,90,218,213,153,108,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f12bace-72ee-4042-9a07-c5a18b5d88ca"));
		}

		#endregion

	}

	#endregion

}

