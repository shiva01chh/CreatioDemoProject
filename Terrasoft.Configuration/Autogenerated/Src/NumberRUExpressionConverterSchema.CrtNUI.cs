﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NumberRUExpressionConverterSchema

	/// <exclude/>
	public class NumberRUExpressionConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NumberRUExpressionConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NumberRUExpressionConverterSchema(NumberRUExpressionConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("94c89bb0-9153-4d00-bf41-1a0b0745997b");
			Name = "NumberRUExpressionConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("75f7d434-56de-4d62-8a8c-9fe090e3ebb1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,91,111,218,48,20,126,166,82,255,195,89,166,73,206,84,37,236,21,40,18,163,76,234,3,85,181,178,237,97,218,131,147,28,32,83,98,35,95,218,162,170,255,125,199,177,29,40,69,227,129,200,159,207,119,241,57,182,224,45,234,29,47,17,86,168,20,215,114,109,178,185,20,235,122,99,21,55,181,20,151,23,47,151,23,3,171,107,177,129,135,189,54,216,142,79,214,217,10,159,13,129,4,127,84,184,33,14,204,27,174,245,8,238,108,91,160,250,254,99,241,188,83,168,53,237,144,244,35,42,131,170,43,207,243,28,38,218,182,45,87,251,105,88,123,14,24,9,218,40,103,194,148,37,42,23,41,96,47,3,101,212,129,210,89,101,81,44,63,82,251,125,198,118,102,72,180,176,6,89,18,195,37,233,31,42,222,217,162,169,75,175,246,191,220,48,130,219,115,48,73,188,116,103,234,123,176,68,179,149,21,117,225,190,147,246,155,167,39,238,128,160,162,65,248,179,63,242,198,98,214,151,231,167,245,147,29,87,188,5,65,163,187,78,186,226,100,122,119,76,157,228,93,197,121,2,87,27,219,162,48,58,153,194,172,170,106,55,100,222,64,15,191,103,43,52,86,9,61,141,167,173,98,208,195,144,162,111,44,117,220,208,210,80,177,112,37,156,26,47,139,191,88,26,207,184,138,187,189,59,92,67,146,164,224,238,220,96,80,97,89,183,148,141,190,227,14,168,215,192,62,4,52,91,169,253,61,87,26,25,243,34,105,144,148,214,56,70,26,85,6,62,84,176,202,22,237,206,236,189,220,107,247,175,159,106,83,110,129,245,25,122,98,201,53,66,50,39,44,25,129,135,250,76,37,161,20,54,134,249,214,72,169,24,173,224,51,124,25,14,83,248,228,62,227,64,10,9,28,39,91,201,135,46,8,75,134,195,36,29,31,59,221,120,177,131,153,175,252,106,235,166,162,118,235,130,12,5,62,193,27,152,69,141,129,191,3,183,226,151,84,149,118,175,152,78,204,75,115,83,52,63,93,103,130,45,171,36,13,6,83,202,122,5,10,215,36,155,158,228,212,197,33,101,220,171,112,205,109,99,250,104,161,244,157,167,187,33,179,86,90,97,86,114,201,27,231,202,150,220,108,105,92,86,148,238,2,116,179,57,26,192,107,120,55,40,42,255,116,186,181,71,223,130,132,185,223,63,98,181,57,217,180,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("94c89bb0-9153-4d00-bf41-1a0b0745997b"));
		}

		#endregion

	}

	#endregion

}

