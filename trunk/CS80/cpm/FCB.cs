using System;
using System.Collections.Generic;
using System.Text;

/**************************************************************************
 * Hollow class; it will be implemented later
 **************************************************************************/
namespace CS80.cpm {
	public class FCB {

		public int getBlockByte(int block) {
			return 0;
		}

		public int getBlockWord(int block) {
			return 0;
		}

		public void setBlockByte(int block, int value) {
		}

		public void setBlockWord(int block, int value) {
		}

		public byte[] getBytes() {
			return null;
		}

		public void setBuffer(byte[] buffer, int from) {
		}

		public bool getDeleted( ) {
			return false;
		}

		public int getUser( ){
			return 0;
		}

		public int getEX( ) {
			return 0;
		}

		public int getRC( ) {
			return 0;
		}

		public string getFileName( ) {
			return null;
		}

		public void SetFileName(string FileName ) {
		}

		public void Clear( ) {
		}

		public void ClearBlocks( ) {
		}

		public void SetUser(int aUser) {
		}

		public void SetEX(int anEx) {
		}

		public void SetRC(int aRC) {
		}

		public void SetDeleted( ) {
		}
	}
}
