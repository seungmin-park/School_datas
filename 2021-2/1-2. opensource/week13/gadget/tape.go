package gadget

import "fmt"

type TapePlayer struct {
	Batteries string
}

func (t TapePlayer) Play(song string) {
	fmt.Println(song, "재생중 ...")
}
func (t TapePlayer) Stop() {
	fmt.Println("중지!")
}

type TapeRecorder struct {
	Microphones string
}

func (t TapeRecorder) Play(song string) {
	fmt.Println(song, "재생중 ...")
}
func (t TapeRecorder) Stop() {
	fmt.Println("중지!")
}
func (t TapeRecorder) Record() {
	fmt.Println("녹화중...")
}

type Mp3Player struct {
	BuiltInBatteries string
}

func (t Mp3Player) Play(song string) {
	fmt.Println(song, "mp3음원 재생중 ...")
}

func (t Mp3Player) Stop() {
	fmt.Println("mp3음원 중지!")
}
