using System;
using System.Collections.Generic;
using System.Text;

namespace CS80 {

	/**
	 * $Id: disk.cs, v 1.0 2006/09/16 elfic.one $
	 * 
	 * Disk.java,v 1.3 2004/06/20 16:27:29 mviara Exp
	 * 
	 * Interface to a disk phisical device, the interface must provide the
	 * basic I/O for one disk. This version assume fixed sector size at
	 * 128 byte.
	 *
	 */
	public interface Idisk {

		/**
		 * Check if the disk is mounted
		 * 
		 * @return true if the disk is mounted
		 */
		bool isMounted( );

		/**
		 * Mount the disk
		 */
		void mount( );

		/**
		 * Read one sector
		 *
		 * @param track - Track number (0 based)
		 * @param sector - Sector number  (1 based)
		 * @param buffer - I/O Buffer
		 */
		void read(int track, int sector, byte[] buffer);

		/**
		 * Write one sector
		 *
		 * @param track - Track number (0 based)
		 * @param sector - Sector number  (1 based)
		 * @param buffer - I/O Buffer
		 */
		void write(int track, int sector, byte[] buffer);

		/**
		 * Format one track
		 * 
		 * @param track - Track number (0 based)
		 */
		void format(int track);


		/**
		 * Get the number of sector x track
		 *
		 * @return number of sector x track
		 */
		int getSectorTrack( );

		/**
		 * Diskount the disk
		 */
		void umount( );
	}
}