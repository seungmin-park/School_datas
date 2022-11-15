package b1844050.DepartureDelayCount;

import java.io.IOException;
import org.apache.hadoop.io.IntWritable;
import org.apache.hadoop.io.Text;
import org.apache.hadoop.mapreduce.Reducer;
import org.apache.hadoop.mapreduce.lib.output.MultipleOutputs;

public class DelayCountReducer extends Reducer<Text, IntWritable, Text, IntWritable> {

    private IntWritable result = new IntWritable();
    private MultipleOutputs<Text, IntWritable> mos;

    public void reduce(Text key, Iterable<IntWritable> values, Context context)
            throws IOException, InterruptedException {
        Text outputKey = new Text();
        String[] columns = key.toString().split(",");
        outputKey.set(columns[1] + "," + columns[2]);
        if (columns[0].equals("D")) {
            int sum = 0;
			for (IntWritable value : values) {
				sum += value.get();
			}
            result.set(sum);
            mos.write("departure", outputKey, result);
        }else {
            int sum = 0;
            for (IntWritable value : values) {
                sum += value.get();
            }
            result.set(sum);
            mos.write("arrival", outputKey, result);
        }
    }

    @Override
    protected void setup(Context context)
            throws IOException, InterruptedException {
        mos = new MultipleOutputs<Text, IntWritable>(context);
    }

    @Override
    protected void cleanup(Context context)
            throws IOException, InterruptedException {
        mos.close();
    }
}
