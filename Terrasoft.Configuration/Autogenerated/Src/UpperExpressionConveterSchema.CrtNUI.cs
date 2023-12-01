namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpperExpressionConveterSchema

	/// <exclude/>
	public class UpperExpressionConveterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpperExpressionConveterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpperExpressionConveterSchema(UpperExpressionConveterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("27fcf242-4fd9-4cab-8a03-9f96704724a7");
			Name = "UpperExpressionConveter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,79,49,10,2,49,16,172,13,220,31,150,171,20,36,96,37,106,169,214,22,106,37,22,185,184,119,6,238,146,176,155,136,162,254,221,61,109,79,152,102,118,102,103,24,111,58,228,104,44,194,1,137,12,135,58,233,117,240,181,107,50,153,228,130,47,212,179,80,163,204,206,55,176,127,112,194,110,37,92,112,218,85,28,90,76,56,46,231,122,161,103,240,130,77,0,31,18,100,70,72,87,199,96,91,195,60,5,231,229,205,92,190,247,63,45,250,24,35,210,246,30,9,153,133,139,120,67,74,72,229,228,44,93,49,87,173,179,191,60,24,178,138,19,150,131,74,31,2,18,209,175,120,23,74,160,212,7,36,22,37,124,245,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("27fcf242-4fd9-4cab-8a03-9f96704724a7"));
		}

		#endregion

	}

	#endregion

}

