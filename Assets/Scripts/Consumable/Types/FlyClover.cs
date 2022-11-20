using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyClover : Consumable
{
    // 아이템 : FlyClover
    // 효과 : 10초간 무적상태 + 속도값이 10 추가되어 빠른 속도로 달릴 수 있다
    // 사용시간 후 무적상태 해제 + 아이템 쓰기전 속도 값으로 변경

    // 추가될 속도값
    protected const int k_PlusSpeed = 10;

    // 아이템 정보
    public override string GetConsumableName()
    {
        return "Clover";
    }
    public override ConsumableType GetConsumableType()
    {
        return ConsumableType.CLOVER;
    }

    // 아이템 가격
    public override int GetPremiumCost()
    {
        return 2;
    }

    public override int GetPrice()
    {
        return 10;
    }

    // 아이템 사용시 실행될 메소드
    public override void Tick(CharacterInputController c)
    {
        base.Tick(c);
        // 무적상태 활성화
        c.characterCollider.SetInvincibleExplicit(true);
        // 플레이어 속도 추가
        c.trackManager.speed += k_PlusSpeed;
    }

    public override IEnumerator Started(CharacterInputController c)
    {
        yield return base.Started(c);
        c.characterCollider.SetInvincible(duration);
    }

    public override void Ended(CharacterInputController c)
    {
        base.Ended(c);
        // 무적상태 비활성화
        c.characterCollider.SetInvincibleExplicit(false);
        // 플레이어 속도 아이템 사용 이전 값으로 변경
        c.trackManager.speed -= k_PlusSpeed;
    }
}
