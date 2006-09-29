using System;
using System.Collections.Generic;
using System.Text;

namespace CS80.disk {

	/**
	 * $Id: AbstractDisk.cs,v 1.2 2006/09/16 Elfic.one
	 * 
	 * AbstractDisk.java,v 1.2 2004/06/20 16:27:04 mviara Exp
	 * 
	 * Sample implementation of CS80.Idisk
	 *
	 * 
	 */
	public abstract class AbstractDisk : Idisk {
		/// Standard CP/M 2.2 Sector size
		static public int SECSIZE = 128;

		/**
		 * Default sector track is IBM 3270
		 */
		private int sectorTrack = 26;

		/**
		 * Return sector per track
		 */
		public int getSectorTrack( ) {
			return sectorTrack;
		}

		/**
		 * Set sector per track
		 */
		public void setSectorTrack(int s) {
			sectorTrack = s;
		}

		/**
		 * Calculate offset from track,sector
		 *
		 * @param track Track number
		 * @param sector Sector number
		 */
		protected int getOffset(int track, int sector) {
			return ( track * getSectorTrack( ) + sector - 1 ) * SECSIZE;
		}

		protected void fillSector(byte[] buffer, int b) {
			for ( int i = 0; i < SECSIZE; i++ )
				buffer[i] = (byte) b;
		}

		protected byte[] getFilledSector(int b) {
			byte[] buffer = new byte[SECSIZE];
			fillSector(buffer, b);

			return buffer;
		}

		abstract public bool isMounted( );
		abstract public void mount( );
		abstract public void read(int track, int sector, byte[] buffer);
		abstract public void write(int track, int sector, byte[] buffer);
		abstract public void format(int track);
		abstract public void umount( );
	}
}
