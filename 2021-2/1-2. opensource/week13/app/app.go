package main

// Duck 타이핑

//type 인터페이스 interface{
// 메서드명()
// 메서드명(type)
//}
import "gowork/week13/gadget"

type Player interface {
	Play(string)
	Stop()
}

//func playList(device gadget.TapeRecorder, songs []string){
//func playList(device gadget.TapePlayer, songs []string) {
func playList(device Player, songs []string) {
	for _, song := range songs {
		device.Play(song)
	}
	device.Stop()
}

func main() {
	p1 := gadget.TapePlayer{}
	p2 := gadget.Mp3Player{}
	mixtape1 := []string{"난 알아요", "거짓말", "으르렁"}
	mixtape2 := []string{"라캄파넬라", "G선상의 아리아"}
	playList(p1, mixtape1)
	playList(p2, mixtape2)
}
