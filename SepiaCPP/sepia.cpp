const float max_val = 255.0f;

float min(float x, float y) {
	if (x < y) {
		return x;
	}
	else {
		return y;
	}
}

void Sepia(float* pixels, int size, float* sepia_rates, float* rgb_rates, int bytes_pp, int start, int end) {
	for (int i = start; i < end && i < size; i += bytes_pp) {
		float pixel = pixels[i] * rgb_rates[0] + pixels[i + 1] * rgb_rates[1] + pixels[i + 2] * rgb_rates[2];
		pixels[i] = pixel;
		pixels[i + 1] = min(pixel + sepia_rates[1], max_val);
		pixels[i + 2] = min(pixel + sepia_rates[2], max_val);
	}
}

extern "C" __declspec(dllexport) void sepiaCpp(float* pixels, int size, float* sepia_rates, float* rgb_rates, int bytes_pp, int start, int end) {
	Sepia(pixels, size, sepia_rates, rgb_rates, bytes_pp, start, end);
}