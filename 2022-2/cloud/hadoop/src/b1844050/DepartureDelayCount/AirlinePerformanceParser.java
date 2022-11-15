package b1844050.DepartureDelayCount;

import org.apache.hadoop.io.Text;

public class AirlinePerformanceParser {
    private int year;
    private int month;
    private int departureDelayTime = 0;
    private int arriveDelayTime = 0;
    private boolean departureDelayAvailable = true;
    private boolean arriveDelayAvailable = true;

    public AirlinePerformanceParser(Text text) {
        try {
            String[] columns = text.toString().split(",");
            year = Integer.parseInt(columns[0]);
            month = Integer.parseInt(columns[1]);
            if (!columns[15].equals("NA")) {
                departureDelayTime = Integer.parseInt(columns[15]);
            } else {
                departureDelayAvailable = false;
            }
			if (!columns[14].equals("NA")) {
				arriveDelayTime = Integer.parseInt(columns[14]);
			} else {
				arriveDelayAvailable = false;
			}
        } catch (Exception e) {
            System.out.println("Error parsing a record :" + e.getMessage());
        }
    }

    public int getYear() {
        return year;
    }

    public int getMonth() {
        return month;
    }

    public int getDepartureDelayTime() {
        return departureDelayTime;
    }

    public int getArriveDelayTime() {
        return arriveDelayTime;
    }

    public boolean isDepartureDelayAvailable() {
        return departureDelayAvailable;
    }

    public boolean isArriveDelayAvailable() {
        return arriveDelayAvailable;
    }
}
